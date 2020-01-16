using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly int a = 10;

        private readonly int b = 5;

        private readonly int c = 0;

        private readonly double d = 9.0;

        private readonly double e = 3.0;

        private readonly int f = 49;

        Calculator calculator = new Calculator();

        [TestMethod()]

        public void AddTest()

        {

            Assert.AreEqual(15, calculator.Sum(a, b));
        }

       
        [TestMethod()]

        public void DivideIntTest()

        {

            Assert.AreEqual(2, calculator.Quotient(a, b));
        }

        [TestMethod()]

        public void SubtractIntTest()

        {

            Assert.AreEqual(5, calculator.Subtract(a, b));
        }

        [TestMethod()]

        public void MultiplyIntTest()

        {

            Assert.AreEqual(50, calculator.Multiply(a, b));

        }

        [TestMethod()]

        public void SquaredNumberIntTest()

        {

            int x = a * a;

            int z = calculator.Square(a);

            Assert.AreEqual(x, z);

        }

        [TestMethod()]

        public void RootIntTest()

        {

            Assert.AreEqual(7, calculator.Root(f));

        }

        [TestMethod()]

        public void AddDoubleTest()

        {

            Assert.AreEqual(12, calculator.Sum(d, e));

        }

        [TestMethod()]

        public void SubtractDoubleTest()

        {

            Assert.AreEqual(6, calculator.Subtract(d, e));

        }

        [TestMethod()]

        public void MultiplyDoubleTest()

        {
            Assert.AreEqual(27, calculator.Multiply(d, e));

        }

        [TestMethod()]

        public void DivideDoubleTest()

        {



            Assert.AreEqual(3, calculator.Quotient(d, e));

        }

        [TestMethod()]

        public void SquareDoubleTest()

        {

            double x = d * d;

            double z = calculator.Square(d);

            Assert.AreEqual(x, z);

        }

       


        [TestMethod()]

        public void RootDoubleTest()

        {

            Assert.AreEqual(3, calculator.Root(d));


        }

        [TestMethod()]

        public void QuoIntDivideZeroTest()

        {

            Assert.ThrowsException<DivideByZeroException>(() => calculator.Quotient(a, c));

        }
    }
}