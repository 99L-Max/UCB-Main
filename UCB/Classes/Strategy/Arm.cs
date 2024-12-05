using System;

namespace UCB
{
    enum TypeProcessingData { TotalNumberData, BatchSize }

    class Arm
    {
        private readonly OneStepIncome _oneStepIncome;
        private readonly int _deltaCounter;

        public readonly double Parameter;
        public readonly double Expectation;
        public readonly bool EstimationVariance;
        public readonly TypeProcessingData TypeProcessingData;

        public Arm(Distribution distribution, double expectation, double maxVariance, int batchSize, double parameter, TypeProcessingData type, bool estimation)
        {
            _oneStepIncome = new OneStepIncome(distribution);
            _deltaCounter = type == TypeProcessingData.TotalNumberData ? batchSize : 1;

            Expectation = expectation;
            Variance = maxVariance;
            BatchSize = batchSize;
            Parameter = parameter;
            TypeProcessingData = type;
            EstimationVariance = estimation;
        }

        public Distribution Distribution =>
            _oneStepIncome.Distribution;

        public double Variance { get; private set; }

        public int BatchSize { get; private set; }

        public int Counter { get; private set; }

        public double Income { get; private set; }

        public double UCB { get; private set; }

        public void Reset() =>
            UCB = Income = Counter = 0;

        public void Play(ref int sumCounter)
        {
            sumCounter += _deltaCounter;
            Counter += _deltaCounter;

            for (int i = 0; i < BatchSize; i++)
                Income += _oneStepIncome.GetIncome(Expectation);

            if (EstimationVariance && Distribution == Distribution.Bernoulli)
                if (TypeProcessingData == TypeProcessingData.TotalNumberData)
                {
                    Variance = Income * (Counter - Income) / (Counter * (Counter - 1));
                }
                else
                {
                    var countData = BatchSize * Counter;
                    Variance = BatchSize * Income * (countData - Income) / (countData * (countData - 1));
                }
        }

        public void SetUCB(int countData) =>
            UCB = Income / Counter + Parameter * Math.Sqrt(Variance * Math.Log(countData) / Counter);
    }
}
