using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsStandardDeviation;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsStandardDeviation.Tests
{
    [TestClass()]
    public class FindStandardDevTests
    {
        public static FindStandardDev findStandardDev = new FindStandardDev();
        [TestMethod()]
        public void StandardDevIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            double standDev = findStandardDev.StandardDev(values);
            Assert.AreEqual(1.41421, Helpers.Rounding.RoundFiveDecimals(standDev));

        }
        public void StandardDevDoubleTest()
        {
            double[] values = { 2.0, 3.0, 4.0 };
            double standDev = findStandardDev.StandardDev(values);
            Assert.AreEqual(0.81650, Helpers.Rounding.RoundFiveDecimals(standDev));
        }
    }
}