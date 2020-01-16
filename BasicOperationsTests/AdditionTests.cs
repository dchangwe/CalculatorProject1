using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 50;
        private readonly int b = 10;
        private readonly double c = 2.5;
        private readonly double d = 1.3;
        private readonly int[] e = { 5, 7, 6 };
        private readonly double[] f = { 2.1, 1.5 };

        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(60, Addition.Sum(a, b));
        }

        [TestMethod()]
        public void SumDoubleTest()
        {
            Assert.AreEqual(3.8, Addition.Sum(c, d));
        }

        [TestMethod()]
        public void SumIntArrayTest()
        {
            Assert.AreEqual(18, Addition.Sum(e));
        }

        [TestMethod()]
        public void SumDoubleArrayTest()
        {
            Assert.AreEqual(3.6, Addition.Sum(f));
        }
    }
}