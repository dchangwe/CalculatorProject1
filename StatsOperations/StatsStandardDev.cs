using System;
using System.Collections.Generic;
using System.Text;
using BasicOperations;

namespace StatsOperations
{
   public class StatsStandardDev
    {
        public static double StandardDev(dynamic values)
        {
            double variance = StatsVariance.Variance(values);
            double standardDev = SquareRootNumber.Root(variance);
            return standardDev;
        }
    }
}
