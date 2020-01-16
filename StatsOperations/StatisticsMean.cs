using System;
using BasicOperations;

namespace StatsOperations
{
    public class StatisticsMean
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = Addition.Sum(values);
            var valueCount = Helpers.Arrays.Length(values);
            var result = Division.Quotient(sum, valueCount);
            return result;
        }
    }
}
