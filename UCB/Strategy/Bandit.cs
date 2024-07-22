using System;
using System.Collections.Generic;
using System.Linq;

namespace UCB
{
    class Bandit
    {
        public const int MinBanditArms = 2;

        private readonly Arm[] _arms;
        private readonly double _sqrtDivDN;
        private readonly double _sqrtMulDN;

        private int _sumCounter;
        private Dictionary<double, double> _regrets;

        public readonly Distribution Distribution;
        public readonly TypeProcessingData TypeProcessingData;
        public readonly double Expectation;
        public readonly double MaxVariance;
        public readonly double Parameter;
        public readonly int NumberBatches;
        public readonly int BatchSize;
        public readonly int Horizon;
        public readonly bool EstimationVariance;

        public Action PointProcessed;
        public Action<Bandit> SimulationFinished;

        public Bandit(double expectation, double maxVariance, Distribution distribution, TypeProcessingData typeProcessingData, int countArms, int numberBatches, int batchSize, double parameter, bool estimationVariance, Dictionary<double, double> regrets = null)
        {
            if (countArms < MinBanditArms)
                throw new ArgumentException($"Минимальное число рук бандита J = {MinBanditArms}.");

            Expectation = expectation;
            MaxVariance = maxVariance;
            Distribution = distribution;
            TypeProcessingData = typeProcessingData;
            EstimationVariance = estimationVariance;
            NumberBatches = numberBatches;
            BatchSize = batchSize;
            Horizon = batchSize * numberBatches;
            Parameter = parameter;

            _arms = new Arm[countArms];
            _sqrtDivDN = Math.Sqrt(MaxVariance / Horizon);
            _sqrtMulDN = Math.Sqrt(MaxVariance * Horizon);

            if (regrets != null)
            {
                _regrets = regrets;
                (MaxDeviation, MaxRegrets) = GetMaxPair(_regrets);
            }
        }

        public double MaxDeviation { get; private set; }

        public double MaxRegrets { get; private set; }

        public Dictionary<double, double> Regrets =>
            _regrets.ToDictionary(k => k.Key, v => v.Value);

        public int CountArms =>
            _arms.Length;

        private (double, double) GetMaxPair(Dictionary<double, double> dict)
        {
            var pair = dict.Aggregate((max, next) => next.Value > max.Value ? next : max);
            return (pair.Key, pair.Value);
        }

        public void Play(double[] deviations, int countGames)
        {
            double maxIncome;
            _regrets = deviations.ToDictionary(k => k, v => 0d);

            foreach (var dev in deviations)
            {
                if (dev == 0d)
                {
                    PointProcessed?.Invoke();
                    continue;
                }

                for (int i = 0; i < _arms.Length; i++)
                    _arms[i] = new Arm(Distribution, Expectation + (i == 0 ? dev : -dev) * _sqrtDivDN, MaxVariance, BatchSize, Parameter, TypeProcessingData, EstimationVariance);

                maxIncome = _arms.Select(x => x.Expectation).Max() * Horizon;

                for (int num = 0; num < countGames; num++)
                {
                    _sumCounter = 0;

                    foreach (var arm in _arms)
                    {
                        arm.Reset();
                        arm.Play(ref _sumCounter);
                    }

                    for (int i = CountArms; i < NumberBatches; i++)
                    {
                        foreach (var arm in _arms)
                            arm.SetUCB(_sumCounter);

                        _arms.OrderByDescending(x => x.UCB).First().Play(ref _sumCounter);
                    }

                    _regrets[dev] += maxIncome - _arms.Select(x => x.Income).Sum();
                }

                _regrets[dev] /= countGames * _sqrtMulDN;
                PointProcessed?.Invoke();
            }

            (MaxDeviation, MaxRegrets) = GetMaxPair(_regrets);
            SimulationFinished?.Invoke(this);
        }
    }
}
