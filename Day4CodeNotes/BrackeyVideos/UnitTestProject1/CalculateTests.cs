using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxApp;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculateTests
    {

        private static Person CreatePerson()
        {
            Person josh = new Person()
            {
                FirstName = "Josh",
                LastName = "Christiansen",
                Age = 4
            };
            return josh;
        }

        [TestMethod]
        public void AgeLessThanFiveTest()
        {
            //Arrange
            Person josh = CreatePerson();

            Tax tax = new Tax();
            var amountToTax = 100m;
            //Act
            decimal result = tax.Calculate(josh, amountToTax);
            //Assert
            Assert.AreEqual(0, result);
        }

        public void TestIfThursday()
        {
            //Arrange
            
            //Act

            //Assert
        }
        [TestMethod]
        public void TestIfLastNameW()
        {
            //Arrange
            Person James = new Person()
            {
                FirstName = "James",
                LastName = "Winston",
                Age = 24
            };
            Tax tax = new Tax();
            decimal amountToTax = 10m;
            //Act
            decimal result = tax.Calculate(James, amountToTax);
            //Assert
            Assert.AreEqual(1.6m, result);
        }
    }
}
