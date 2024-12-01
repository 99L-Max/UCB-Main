using System;
using System.Collections.Generic;
using System.Linq;

namespace UCB
{
    static class CollectionHandler
    {
        public static bool CheckArraysLength(params Array[] arrays) =>
            arrays.All(arr => arr.Length == arrays[0].Length);

        public static (double, double) GetPairMaxValue(Dictionary<double, double> dict)
        {
            var pair = dict.Aggregate((max, next) => next.Value > max.Value ? next : max);
            return (pair.Key, pair.Value);
        }

        public static double[] CreateArray(double start, double step, int count, int decimalPlaces = 2) =>
            Enumerable.Range(0, count).Select(i => Math.Round(start + i * step, decimalPlaces)).ToArray();
    }
}
