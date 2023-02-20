using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass()]
    public class OddEvenKataTests
    {
        [TestMethod()]
        public void PrintNumbersShouldReturnEvenIfNumberIsEven()
        {
            //Arrange
            int number = 4;
            //Act
            string result = OddEvenKata.PrintNumbers(number);
            //Assert
            Assert.AreEqual("Even", result);
        }

        [TestMethod()]

        public void PrintNumberShouldReturnOddNumberWhenNumberIsNotPrime()
        {
            //Arrange
            int number = 9;
            //Act
            string result = OddEvenKata.PrintNumbers(number);
            //Assert
            Assert.AreEqual("Odd", result);
        }

        [TestMethod()]
        public void PrintNumbersIfTheyArePrimeAndNotEvenOrOdd()
        {
            //Arrange
            int number = 19;
            string expected = "19";
            //Act
            string actual = OddEvenKata.PrintNumbers(number);
            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}