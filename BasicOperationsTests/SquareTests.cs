using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int a = 8;
        private readonly double b = 1.2;

        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(64, Squared.Square((double)a));

        }

        [TestMethod()]
        public void SqauredTest()
        {
            Assert.AreEqual(1.44, Squared.Square(b));
        }
    }
}