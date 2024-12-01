using System;

namespace UCB
{
    enum Distribution { Gaussian, Bernoulli }

    class OneStepIncome
    {
        private readonly Random _random = new Random();
        private readonly Func<double, double> _getNumber;

        public readonly Distribution Distribution;

        public OneStepIncome(Distribution distribution)
        {
            Distribution = distribution;

            if (distribution == Distribution.Gaussian)
                _getNumber = GetGaussianNumber;
            else
                _getNumber = GetBernoulliNumber;
        }

        private double GetGaussianNumber(double expectation)
        {
            double norm = expectation - 6d;

            for (int i = 0; i < 12; i++)
                norm += _random.NextDouble();

            return norm;
        }

        private double GetBernoulliNumber(double expectation) =>
            _random.NextDouble() < expectation ? 1d : 0d;

        public double GetIncome(double expectation) =>
            _getNumber(expectation);
    }
}
