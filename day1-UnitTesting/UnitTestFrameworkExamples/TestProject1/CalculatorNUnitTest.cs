using NUnit.Framework.Legacy;
using CalculatorApp;
using System;

/// NUNIT Test

namespace CalculatorApp.Tests
{
    [TestFixture]          // [TestClass] in MSTest 
    public class CalculatorTests
    {
        private Calculator calculator;  private MultipleExcept multiExcept;    // Object Reference

        [SetUp]         // [TestInitialize] in MsTest
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]          // [TestMethod] in MsTest
        public void Run()
        {
            Assert.Pass();
        }


        [Test]
        public void Add_WhenCalled_ReturnsCorrectSum()
        {
            int result = calculator.Add(10, 5);
            ClassicAssert.AreEqual(15, result);          // For Nunit version < 4 : use Assert only with .AreEqual,  .AreNotEqual, .IsTrue/.IsFalse
        }

        [Test]
        public void Subtract_WhenCalled_ReturnsCorrectResult()
        {
            int result = calculator.Subtract(10, 3);
            ClassicAssert.AreEqual(7, result);
        }

        [Test]
        public void Multiply_WhenCalled_ReturnsCorrectResult()
        {
            int result = calculator.Multiply(4, 5);
            ClassicAssert.AreEqual(20, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }



        /// <summary>
        /// Multiple Exceptions Test Scenarios
        /// </summary>
        /// 

        // Different test Methods

        [Test]
        public void TestInputExcept_Less_1()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => multiExcept.InputExcept(-1)); 
        }

        [Test]
        public void TestInputExcept_Equals_0()
        {
            Assert.Throws<NullReferenceException>(() => multiExcept.InputExcept(7));
        }

        // Or all exceptions in one 
        [Test]
        public void MultipleException()
        {
            Assert.That(
                () => multiExcept.InputExcept(1),
                Throws.TypeOf<NullReferenceException>().Or.TypeOf<ArgumentOutOfRangeException>()
                );
        }



    }
}