using System;
using BasicCalculator;
using StatisticsMean;
using StatsStandardDeviation;
using StatsVariance;

namespace StatisticsCalculator
{
    
        public class StatsCalculator : Calculator, IStatsMean, IFindStandardDev, IFindVariance
        {
            private readonly StatsMean mean = new StatsMean();
            private readonly FindStandardDev standardDev = new FindStandardDev();
            private readonly FindVariance variance = new FindVariance();
            
            public dynamic Mean(dynamic values)
            {
                return mean.Mean(values);
            }
            public double Variance(dynamic values)
            {
                return variance.Variance(values);
            }
            public double StandardDev(dynamic values)
            {
                return standardDev.StandardDev(values);
            }
            
        }
    }

