using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatsCalculatorTests
    {
        private readonly StatsCalculator statsCal = new StatsCalculator();
        private readonly int[] values = { 2, 4, 6, 8 };
        private readonly int score = 3;
        private readonly double[] doubleVal = { 2.0, 3.0, 4.0 };
        private readonly double doubleScore = 2.2;

        [TestMethod]
        public void FindMeanIntTest()
        {
            var mean = statsCal.Mean(values);
            Assert.AreEqual(5, mean);
        }
        [TestMethod()]
        public void VarianceIntTest()
        {
            var mean = statsCal.Variance(values);
            Assert.AreEqual(5, mean);
        }
        [TestMethod()]
        public void StandDevIntTest()
        {
            var standDev = statsCal.StandardDev(values);
            Assert.AreEqual(2.23607, Helpers.Rounding.RoundFiveDecimals(standDev));
        }
       

        [TestMethod()]
        public void MeanDoubleTest()
        {
            var mean = statsCal.Mean(doubleVal);
            Assert.AreEqual(3, mean);
        }

        [TestMethod()]
        public void VarianceDoubleTest()
        {
            var variance = statsCal.Variance(doubleVal);
            Assert.AreEqual(0.66667, Helpers.Rounding.RoundFiveDecimals(variance));
        }

        [TestMethod()]
        public void StandDevDoubleTest()
        {
            var standDev = statsCal.StandardDev(doubleVal);
            Assert.AreEqual(0.81650, Helpers.Rounding.RoundFiveDecimals(standDev));
        }

    }
}