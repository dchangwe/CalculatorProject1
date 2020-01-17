using System;
using StatsOperations;

namespace StatsStandardDeviation
{
    public class FindStandardDev
    {
        public static dynamic result;
        public double StandardDev(dynamic arrayA)
        {
            result =StatStandardDev.StandardDev(arrayA);
            return result;
        }
    }
}
