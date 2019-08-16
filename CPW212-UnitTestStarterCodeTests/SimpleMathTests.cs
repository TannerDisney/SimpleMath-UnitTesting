using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Arrange
            double expectedResult = num1 + num2;

            // Act
            double result = SimpleMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Arrange
            double num1 = 5;
            double num2 = 10;
            double expectedResult = 50;

            // Act
            double result = SimpleMath.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result);
            
        }

        // Divide by zero should throw an argument exception with a message
        // "Denominator cannot be zero"
        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Arrange
            double num1 = 300;
            double num2 = 0;

            // Act => Assert
            Assert.ThrowsException<DivideByZeroException>
                (() => SimpleMath.Divide(num1, num2));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(100, 50)]
        [DataRow(28, 2)]
        [DataRow(81, 9)]
        [DataRow(800, 8)]
        public void Divide_TwoValidNumbers_ReturnsDivisible(double num1, double num2)
        {
            // Arrange
            double expectedResult = num1 / num2;

            // Act
            double result = SimpleMath.Divide(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result);
            
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Subtract_TwoValidNumbers_ReturnsSubtractedResult(double num1, double num2)
        {
            // Arrange
            double expectedResult = num1 - num2;

            // Act
            double result = SimpleMath.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}