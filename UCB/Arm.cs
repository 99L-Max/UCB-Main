using System;

namespace UCB
{
    enum EstimationDispersion
    {
        Never,
        OnlyOnInitialStage,
        Always
    }

    class Arm
    {
        private readonly Random random = new Random();

        public readonly double Expectation;

        public Arm(double expectation, double dispersion)
        {
            Expectation = expectation;
            Dispersion = dispersion;
        }

        public double Dispersion { private set; get; }

        public int Counter { private set; get; }

        public double Income { private set; get; }

        public double AvgIncome => Income / Counter;

        public void Reset()
        {
            Counter = 0;
            Income = 0d;
        }

        public void Select(ref int sumCounter)
        {
            Income += Expectation - 6d;

            for (int i = 0; i < 12; i++)
                Income += random.NextDouble();

            Counter++;
            sumCounter++;
        }

        public void Select(int data, int dCounter, ref int sumCounter)
        {
            sumCounter += dCounter;
            Counter += dCounter;

            while (data-- > 0)
                if (random.NextDouble() < Expectation)
                    Income++;
        }

        public void EstimateDispersion(TypeProcessingData type, int batchSize)
        {
            if (type == TypeProcessingData.TotalNumberData)
            {
                Dispersion = Income * (Counter - Income) / (Counter * (Counter - 1));
            }
            else
            {
                int countData = batchSize * Counter;
                Dispersion = batchSize * Income * (countData - Income) / (countData * (countData - 1));
            }
        }
    }
}
