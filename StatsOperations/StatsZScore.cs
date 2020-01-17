using System;
using System.Collections.Generic;
using System.Text;
using BasicOperations;
namespace StatsOperations
{
 public  class StatsZScore
    {
        public static double StatZScore(dynamic score, dynamic values)
        {
            double mean = StatisticMean.Mean(values);
            double standDev = StatStandardDev.StandardDev(values);
            double zScore = Division.Quotient(Subtraction.Subtract(score, mean), standDev);
            return zScore;
        }
    }
}
