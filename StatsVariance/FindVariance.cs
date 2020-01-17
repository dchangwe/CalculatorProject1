using System;
using StatsOperations;

namespace StatsVariance
{
    public class FindVariance : IFindVariance
    {
        public static dynamic result;
        public double Variance(dynamic arrayA)
        {
            result = StatVariance.Variance(arrayA);
            return result;
        }
    }
}
