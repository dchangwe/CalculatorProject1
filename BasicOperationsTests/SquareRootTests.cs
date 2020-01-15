using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        private readonly int a = 8;
        private readonly double d = 25.0;
        [TestMethod()]
        public void SqRootTest()
        {
            Assert.AreEqual(3, SquareRoot.SqRoot(a));
        }

        [TestMethod()]
        public void SqRoot()
        {
            Assert.AreEqual(5, SquareRoot.SqRoot(d));
        }
    }
}