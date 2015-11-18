using System;
using CalculatorApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorApplicationTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void WantToTestAddFunctionality()
        {
            var cal1 = new Calculator();
            double add = cal1.Addition(2, 2);
            Assert.AreEqual(4, add);
        }
        [TestMethod]
        public void WantToTestDecimalAddition1()
        {
            var cal2 = new Calculator();
            double add = cal2.Addition(2.2, 2);
            Assert.AreEqual(4.2, add);
        }
        [TestMethod]
        public void WantToTestDecimalAddition2()
        {
            var cal2 = new Calculator();
            double add = cal2.Addition(2, 2.2);
            Assert.AreEqual(4.2, add);
        }
        [TestMethod]
        public void WantToTestDecimalAddition3()
        {
            var cal2 = new Calculator();
            double add = cal2.Addition(2.2, 2.2);
            Assert.AreEqual(4.4, add);
        }
        [TestMethod]
        public void WantToTestSubFunctionality()
        {
            var cal1 = new Calculator();
            double sub = cal1.Substraction(2, 2);
            Assert.AreEqual(0, sub);
        }
        [TestMethod]
        public void WantToTestDecimalSubstraction1()
        {
            var cal2 = new Calculator();
            double sub = cal2.Substraction(2.2, 1.1);
            Assert.AreEqual(1.1, sub);
        }
        [TestMethod]
        public void WantToTestDecimalSubstraction2()
        {
            Calculator calculator = new Calculator();
            double sub = calculator.Substraction(2, 1.0);
            Assert.AreEqual(1.0, sub);
        }
        [TestMethod]
        public void WantToTestDecimalSubstraction3()
        {
            Calculator calculator = new Calculator();
            double sub = calculator.Substraction(2.0, 1);
            Assert.AreEqual(1.0, sub);
        }
        [TestMethod]
        public void WantToTestMultiplicationFunctionality()
        {
            var cal1 = new Calculator();
            double mul = cal1.Multiplication(2, 2);
            Assert.AreEqual(4, mul);
        }
        [TestMethod]
        public void WantToTestDecimalMultiplication1()
        {
            var cal1 = new Calculator();
            double mul = cal1.Multiplication(2.2, 2);
            Assert.AreEqual(4.4, mul);
        }
        [TestMethod]
        public void WantToTestDecimalMultiplication2()
        {
            var cal2 = new Calculator();
            double mul = cal2.Multiplication(2.2, 1.2);
            Assert.AreEqual(2.64, mul);
        }
        [TestMethod]
        public void WantToTestDecimalMultiplication3()
        {
            var cal2 = new Calculator();
            double mul = cal2.Multiplication(3, 6.0);
            Assert.AreEqual(18.0, mul);
        }
        [TestMethod]
        public void WantToTestDivisionFunctionality()
        {
            var cal2 = new Calculator();
            double div = cal2.Division(2, 1);
            Assert.AreEqual(2, div);
        }
        [TestMethod]
        public void WantToTestDecimalDivision()
        {
            var cal2 = new Calculator();
            double div = cal2.Division(4.4, 2);
            Assert.AreEqual(2.2, div);
        }
        [TestMethod]
        public void WantToTestDecimalDivision2()
        {
            var cal2 = new Calculator();
            double div = cal2.Division(4.4, 2.2);
            Assert.AreEqual(2, div);
        }
        [TestMethod]
        public void WantToTestDecimalDivisio3()
        {
            var cal2 = new Calculator();
            double div = cal2.Division(4, 2.0);
            Assert.AreEqual(2.0, div);
        }
    }
}
