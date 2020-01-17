﻿using System;
using System.Collections.Generic;
using System.Text;
using BasicOperations;

namespace StatsOperations
{
   public class StatVariance
    {
        public static double Variance(dynamic values)
        {
            double mean = StatisticMean.Mean(values);
            double difference = 0;
            double variance = 0;
            foreach (int a in values)
            {
                difference = Subtraction.Subtract((int)mean, a);
                difference = Math.Pow(difference, 2);
                variance = Addition.Sum(variance, (int)difference);
               
            }
            int ValueCount = Helpers.Arrays.Length(values);
            variance = Division.Quotient(variance, ValueCount);
            return variance;
            
        }
    }
}
