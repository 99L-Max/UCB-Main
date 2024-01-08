using System;
using System.Linq;

namespace UCB
{
    enum TypeBandit
    {
        Gauss,
        Bernuolli
    }

    abstract class Bandit
    {
        private readonly double[] ucb;

        private static double expectation;
        private static double[] deviations;

        protected readonly Arm[] arms;
        protected readonly double SqrtDivDN;
        protected readonly double SqrtMulDN;

        protected Random random = new Random();
        protected int sumCounter;
        protected double[] regrets;

        public const int MinBanditArms = 2;

        public readonly int Horizon;
        public readonly double Parameter;

        public static int NumberSimulations;
        public static double MaxDispersion;
        public static TypeBandit TypeBandit;

        public delegate void EventStateChanged();
        public event EventStateChanged PointProcessed;
        public event EventStateChanged SimulationFinished;

        public Bandit(int countArms, int horizon, double parameter)
        {
            if (countArms < MinBanditArms)
                throw new ArgumentException($"Минимальное число рук бандита J = {MinBanditArms}.");

            arms = new Arm[countArms];
            ucb = new double[countArms];

            Horizon = horizon;
            Parameter = parameter;

            SqrtDivDN = Math.Sqrt(MaxDispersion / horizon);
            SqrtMulDN = Math.Sqrt(MaxDispersion * horizon);
        }

        //Конструктор для чтения файла
        public Bandit(int countArms, int horizon, double parameter, double[] regrets) :
            this(countArms, horizon, parameter)
        {
            this.regrets = regrets;
            MaxRegrets = this.regrets[0];
            MaxDeviation = deviations[0];

            for (int i = 1; i < regrets.Length; i++)
                if (this.regrets[i] > MaxRegrets)
                {
                    MaxRegrets = this.regrets[i];
                    MaxDeviation = deviations[i];
                }
        }

        protected int IndexMaxUCB { private set; get; }

        public double MaxDeviation { protected set; get; }

        public double MaxRegrets { protected set; get; } = 0d;

        public double[] Regrets => (double[])regrets.Clone();

        public int CountArms => arms.Length;

        public static int NumberDeviations => deviations.Length;

        public static double Expectation
        {
            set
            {
                if (TypeBandit == TypeBandit.Bernuolli && (value > 1d || value < 0d))
                    throw new ArgumentException("Для распределения Бернулли мат. ожидание p должно быть в пределах от 0 до 1 включительно.");

                expectation = value;
            }
            get => expectation;
        }

        public static double StepDevition { private set; get; }

        protected void EventPointProcessed() => PointProcessed.Invoke();

        protected void EventSimulationFinished() => SimulationFinished.Invoke();

        protected void UCB()
        {
            double maxUCB = double.MinValue;

            for (int i = 0; i < arms.Length; i++)
            {
                ucb[i] = arms[i].AvgIncome + Parameter * Math.Sqrt(arms[i].Dispersion * Math.Log(sumCounter) / arms[i].Counter);

                if (maxUCB < ucb[i])
                {
                    maxUCB = ucb[i];
                    IndexMaxUCB = i;
                }
            }
        }

        public double GetRegrets(int i) => regrets[i];

        public abstract void RunSimulation();

        public static void SetDeviations(double initialDeviation, double step, int count)
        {
            deviations = Enumerable.Range(0, count).Select(i => Math.Round(initialDeviation + i * step, 1)).ToArray();
            StepDevition = step;
        }

        public static double GetDeviation(int i) => deviations[i];
    }
}
