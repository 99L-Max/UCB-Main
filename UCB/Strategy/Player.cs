using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace UCB
{
    class Player : IDisposable
    {
        private readonly Stopwatch _stopWatch = new Stopwatch();
        private readonly Bandit[] _bandits;
        private readonly Dictionary<Bandit, Thread> _threads = new Dictionary<Bandit, Thread>();

        private double[] _deviations;
        private int _countProcessedBandits;
        private int _countProcessedPoints;
        private int _totalCountPoints;
        private Queue<Bandit> _waitingBandits;

        public readonly Distribution Distribution;
        public readonly TypeProcessingData TypeProcessingData;
        public readonly double Expectation;
        public readonly double MaxVariance;
        public readonly bool VariancesKnown;

        public Action ProgressChanged;

        public RegretTable RegretTable { get; private set; }

        public int GamesCount { get; private set; }

        public int PercentProgress { get; private set; }

        public string GameResult { get; private set; }

        public bool IsPaused { get; private set; }

        public bool IsPlaying { get; private set; }

        public double[] Deviations =>
            (double[])_deviations.Clone();

        public int BanditCount =>
            _bandits.Length;

        public string GameInformation =>
            $"Обработано {_countProcessedBandits} / {_bandits.Length}\n" +
            $"Выполнено {PercentProgress}%\n" +
            $"Время {GameTime}";

        public string GameTime =>
            $"{_stopWatch.Elapsed.Hours:d2}:{_stopWatch.Elapsed.Minutes:d2}:{_stopWatch.Elapsed.Seconds:d2}";

        private Player(double expectation, double maxVariance, Distribution distribution, TypeProcessingData type, bool variancesKnown)
        {
            Distribution = distribution;
            TypeProcessingData = type;
            VariancesKnown = variancesKnown;
            Expectation = expectation;
            MaxVariance = maxVariance;
        }

        public Player(double expectation, double maxVariance, Distribution distribution, TypeProcessingData type, bool variancesKnown, int[] countArms, int[] numberBatches, int[] batchSize, double[] parameters) :
            this(expectation, maxVariance, distribution, type, !variancesKnown)
        {
            if (!CheckArraysLength(countArms, numberBatches, batchSize, parameters))
                throw new ArgumentException("Несовпадение размером массивов.");

            _bandits = new Bandit[countArms.Length];

            for (int i = 0; i < _bandits.Length; i++)
                _bandits[i] = new Bandit(expectation, maxVariance, distribution, type, countArms[i], numberBatches[i], batchSize[i], parameters[i], variancesKnown);
        }

        public Player(double expectation, double maxVariance, Distribution distribution, TypeProcessingData type, bool variancesKnown, double[] deviations, int gamesCount, Bandit[] bandits, string gameResult) :
            this(expectation, maxVariance, distribution, type, variancesKnown)
        {
            _deviations = (double[])deviations.Clone();
            _bandits = bandits;

            GameResult = gameResult;
            GamesCount = gamesCount;
            RegretTable = new RegretTable(_deviations, _bandits);
        }

        public void Dispose()
        {
            CancelGame();

            foreach (var b in _bandits)
            {
                b.PointProcessed -= UpdateProgress;
                b.SimulationFinished -= FinishThread;
            }
        }

        private bool CheckArraysLength(params Array[] arrays) =>
            arrays.All(arr => arr.Length == arrays[0].Length);

        private void UpdateProgress()
        {
            PercentProgress = ++_countProcessedPoints * 100 / _totalCountPoints;
            ProgressChanged?.Invoke();
        }

        private void StartThread()
        {
            if (_waitingBandits.Count > 0)
            {
                var b = _waitingBandits.Dequeue();
                var th = new Thread(() => b.Play(_deviations, GamesCount));

                b.PointProcessed += UpdateProgress;
                b.SimulationFinished += FinishThread;

                _threads.Add(b, th);
                th.Start();
            }
        }

        private void FinishThread(Bandit sender)
        {
            _countProcessedBandits++;

            sender.PointProcessed -= UpdateProgress;
            sender.SimulationFinished -= FinishThread;

            _threads.Remove(sender);

            StartThread();

            if (_threads.Count == 0)
            {
                _stopWatch.Stop();

                RegretTable = new RegretTable(_deviations, _bandits);

                GameResult =
                    $"a = {_bandits[RegretTable.IndexMinMax].Parameter:f2}\n" +
                    $"l_max = {_bandits[RegretTable.IndexMinMax].MaxRegrets:f2}\n" +
                    $"d_max = {_bandits[RegretTable.IndexMinMax].MaxDeviation:f1}\n" +
                    $"Время {GameTime}";

                IsPlaying = false;
            }
        }

        public void Play(double[] deviations, int countGames, int countThreads)
        {
            PercentProgress = 0;
            GamesCount = countGames;
            GameResult = string.Empty;
            IsPaused = false;
            IsPlaying = true;

            _deviations = (double[])deviations.Clone();
            _countProcessedBandits = _countProcessedPoints = 0;
            _totalCountPoints = deviations.Length * _bandits.Length;
            _waitingBandits = new Queue<Bandit>(_bandits);

            int maxCountThreads = Math.Min(countThreads, _waitingBandits.Count);

            while (maxCountThreads-- > 0)
                StartThread();

            _stopWatch.Restart();
        }

        [Obsolete]
        public void ChangePause()
        {
            if (IsPaused)
            {
                foreach (var th in _threads.Values)
                    if (th.IsAlive) th.Resume();

                _stopWatch.Start();
            }
            else
            {
                foreach (var th in _threads.Values)
                    if (th.IsAlive) th.Suspend();

                _stopWatch.Stop();
            }

            IsPaused = !IsPaused;
        }

        public void CancelGame()
        {
            _stopWatch.Stop();

            foreach (var th in _threads)
            {
                th.Key.PointProcessed -= UpdateProgress;
                th.Key.SimulationFinished -= FinishThread;

                th.Value.Abort();
            }

            IsPlaying = IsPaused = false;
        }

        public string GetJsonString()
        {
            var banditsData = _bandits.Select(b => new
            {
                b.Expectation,
                b.MaxVariance,
                b.Distribution,
                b.TypeProcessingData,
                b.CountArms,
                b.NumberBatches,
                b.BatchSize,
                b.Parameter,
                b.EstimationVariance,
                b.Regrets
            });

            var data = JsonConvert.SerializeObject(new
            {
                Distribution,
                TypeProcessingData,
                Expectation,
                MaxVariance,
                VariancesKnown,
                Deviations,
                GamesCount,
                GameResult,
                Bandits = banditsData
            });

            return data;
        }
    }
}
