using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day4UnitTest.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddNumbers()
        {
            //Arrange
            Calculator calc = new Calculator();
            
            //Act
            int result = calc.AddNumbers(5, 0);

            //Assert  -  What should happen when we run the program
            Assert.AreEqual(5, result, "You cannot do math, as this test did not work!");
        }
    }
}
