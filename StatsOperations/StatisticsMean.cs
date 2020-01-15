using System;
using BasicOperations;

namespace StatsOperations
{
    public class StatisticsMean
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = BasicOperations.Addition.Sum(values);
            var valueCount = Helpers.Arrays.Length(values);
            var result = BasicOperations.Division.Quotient(sum, valueCount);
            return result;
        }
    }
}
