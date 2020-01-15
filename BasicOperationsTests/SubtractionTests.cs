using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 60;
        private readonly int b = 30;
        private readonly double c = 5.5;
        private readonly double d = 1.3;
        private readonly int[] e = { 5, 2, 3 };
        private readonly double[] f = { 6.5, 1.5 };

        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(30, Subtraction.Subtract(a, b));
        }

        [TestMethod()]
        public void SubtractDoubleTest()
        {
            Assert.AreEqual(4.2, Subtraction.Subtract(c, d));
        }

        [TestMethod()]
        public void SubtractIntArrayTest()
        {
            Assert.AreEqual(6, Subtraction.Subtract(e));
        }

        [TestMethod()]
        public void SubtractDoubleArrayTest()
        {
            Assert.AreEqual(-5.0, Subtraction.Subtract(f));
        }
    }

}
