using System;

namespace StatsStandardDeviation
{
    public class FindStandardDev
    {
        public static dynamic result;
        public double StandardDev(dynamic arrayA)
        {
            result = StatsOperations.StatsStandardDev.StandardDev(arrayA);
            return result;
        }
    }
}
