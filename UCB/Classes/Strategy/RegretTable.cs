﻿using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UCB
{
    class RegretTable
    {
        private readonly double[] _deviations;
        private readonly double[] _parameters;
        private readonly double[,] _regrets;

        public readonly int IndexMinMax;

        public RegretTable(IEnumerable<double> deviations, Bandit[] bandits)
        {
            _deviations = deviations.OrderBy(x => x).ToArray();
            _parameters = bandits.Select(b => b.Parameter).ToArray();
            _regrets = new double[_deviations.Length, bandits.Length];

            double max, minMax = double.MaxValue;

            for (int j = 0; j < _regrets.GetLength(1); j++)
            {
                max = double.MinValue;

                for (int i = 0; i < _regrets.GetLength(0); i++)
                {
                    var reg = bandits[j].Regrets;

                    if (reg.ContainsKey(_deviations[i]))
                        _regrets[i, j] = reg[_deviations[i]];

                    if (max < _regrets[i, j])
                        max = _regrets[i, j];
                }

                if (minMax > max)
                {
                    minMax = max;
                    IndexMinMax = j;
                }
            }
        }

        public int CountRows => 
            _deviations.Length;

        public int CountColumns =>
            _parameters.Length;

        public double GetDeviation(int index) =>
            _deviations[index];

        public Dictionary<double, double> GetRegrets(int indexColumn)
        {
            var result = new Dictionary<double, double>();

            for (int i = 0; i < _deviations.Length; i++)
                result.Add(_deviations[i], _regrets[i, indexColumn]);

            return result;
        }

        public override string ToString()
        {
            var result = new StringBuilder("d\\a " + string.Join(" ", _parameters));

            for (int i = 0; i < _regrets.GetLength(0); i++)
            {
                result.Append($"\n{_deviations[i]}");

                for (int j = 0; j < _regrets.GetLength(1); j++)
                    result.Append($" {_regrets[i, j]}");
            }

            return result.ToString();
        }
    }
}
