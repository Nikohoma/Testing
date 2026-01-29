using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using System;

// MsTest

namespace CalculatorApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Add_WhenCalled_ReturnsCorrectSum()
        {
            int result = calculator.Add(10, 5);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Subtract_WhenCalled_ReturnsCorrectResult()
        {
            int result = calculator.Subtract(10, 3);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Multiply_WhenCalled_ReturnsCorrectResult()
        {
            int result = calculator.Multiply(4, 5);
            Assert.AreEqual(20, result);
        }

        //[TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        //public void Divide_ByZero_ThrowsException()
        //{
        //    calculator.Divide(10, 0);
        //}

        [TestMethod]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.ThrowsException<DivideByZeroException>(() =>
                calculator.Divide(10, 0));
        }

    }
}
