using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsOperations.Tests
{
    [TestClass()]
    public class StatVarianceTests
    {
        [TestMethod()]
        public void VarianceTest()
        {
            int[] values = { 2, 4, 6, 8 };
            var variance = StatVariance.Variance(values);
            Assert.AreEqual(5, Helpers.Rounding.RoundFiveDecimals(variance));

        }
        [TestMethod()]
        public void VarianceDoubleTest()
        {
            double[] values = { 2.0, 3.0, 4.0 };
            var variance = StatVariance.Variance(values);
            Assert.AreEqual(0.66667, Helpers.Rounding.RoundFiveDecimals(variance));

        }
    }
}