using System;

namespace StatsVariance
{
    public class FindVariance : IFindVariance
    {
        public static dynamic result;
        public double Variance(dynamic arrayA)
        {
            result = StatsOperations.StatsVariance.Variance(arrayA);
            return result;
        }
    }
}
