using MSD.DotNet.Patterns.TestableCodeRefactoring.Basic;
using NUnit.Framework;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UnitTests.Basic
{
    /// <summary>
    /// Class with unit tests for the basic Calculator without dependencies.
    /// </summary>
    public class CalculatorTests
    {
        [Test]
        public void Add_SingleNumber_ReturnsTheSameNumber()
        {
            // Arrange
            var calculator = GetCalculator();

            // Act
            calculator.Add(1);

            // Assert
            Assert.AreEqual(1, calculator.Value);
        }

        [Test]
        public void Add_TwoNumbers_ReturnsTheSumOfTheNumbers()
        {
            // Arrange
            var calculator = GetCalculator();

            // Act
            calculator.Add(1);
            calculator.Add(2);

            // Assert
            Assert.AreEqual(3, calculator.Value);
        }

        [Test]
        public void Substract_SinglePositiveNumber_ReturnsTheNegativeOfTheNumber()
        {
            // Arrange
            var calculator = GetCalculator();

            // Act
            calculator.Substract(1);

            // Assert
            Assert.AreEqual(-1, calculator.Value);
        }

        [Test]
        public void Substract_TwoNumbers_ReturnsTheDifferenceBetweenTheNumbers()
        {
            // Arrange
            var calculator = GetCalculator();

            // Act
            calculator.Add(3);
            calculator.Substract(2);

            // Assert
            Assert.AreEqual(1, calculator.Value);
        }

        [Test]
        public void Clear_AfterCalculation_ReturnsZero()
        {
            // Arrange
            var calculator = GetCalculator();

            // Act
            calculator.Add(1);
            calculator.Add(2);
            calculator.Clear();

            // Assert
            Assert.AreEqual(0, calculator.Value);
        }

        private static Calculator GetCalculator()
        {
            return new Calculator();
        }
    }
}
