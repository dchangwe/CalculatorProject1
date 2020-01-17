using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers.Tests
{
    [TestClass()]
    public class RoundingTests
    {
        private readonly double number = 18.75640500;
        [TestMethod()]
        public void RoundTwoDecimalsTest()
        {
            Assert.AreEqual(18.76, Helpers.Rounding.RoundTwoDecimals(number));
            
        }

        [TestMethod()]
        public void RoundFourDecimalsTest()
        {
            Assert.AreEqual(18.7564, Helpers.Rounding.RoundFourDecimals(number));
        }

        [TestMethod()]
        public void RoundFiveDecimalsTest()
        {
            Assert.AreEqual(18.75640, Helpers.Rounding.RoundFiveDecimals(number));
        }
    }
}