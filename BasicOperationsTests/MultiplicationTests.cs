using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly int a = 2;
        private readonly int b = 15;
        private readonly double c = 1.2;
        private readonly double d = 3.2;
        private readonly double[] e = { 2.1, 3.2, 2.1 };

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(30, Multiplication.Multiply(a, b));
        }

        [TestMethod()]
        public void MultiplyDoubleTest()
        {
            Assert.AreEqual(3.84, Multiplication.Multiply(c, d));
        }

        [TestMethod()]
        public void MultiplyDoubleArrayTest()
        {
            Assert.AreEqual(0, Multiplication.Multiply(e));
        }
    }
}