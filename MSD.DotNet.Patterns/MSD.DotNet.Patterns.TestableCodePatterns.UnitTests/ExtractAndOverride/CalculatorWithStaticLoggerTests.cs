namespace MSD.DotNet.Patterns.TestableCodePatterns.UnitTests.ExtractAndOverride
{
    using MSD.DotNet.Patterns.TestableCodePatterns.ExtractAndOverride;
    using NUnit.Framework;

    public class CalculatorWithStaticLoggerTests
    {
        [Test]
        public void Add_SingleNumber_ReturnsTheSameNumber()
        {
            // Arrange
            var calculator = new TestableCalculatorWithStaticLogger();

            // Act
            calculator.Add(1);

            // Assert
            Assert.AreEqual(1d, calculator.Result);
        }

        [Test]
        public void Add_TwoNumbers_ReturnsTheSumOfTheNumbers()
        {
            // Arrange
            var calculator = new TestableCalculatorWithStaticLogger();

            // Act
            calculator.Add(1);
            calculator.Add(2);

            // Assert
            Assert.AreEqual(3d, calculator.Result);
        }

        [Test]
        public void Substract_SinglePositiveNumber_ReturnsTheNegativeOfTheNumber()
        {
            // Arrange
            var calculator = new TestableCalculatorWithStaticLogger();

            // Act
            calculator.Substract(1);

            // Assert
            Assert.AreEqual(-1d, calculator.Result);
        }

        [Test]
        public void Substract_TwoNumbers_ReturnsTheDifferenceBetweenTheNumbers()
        {
            // Arrange
            var calculator = new TestableCalculatorWithStaticLogger();

            // Act
            calculator.Add(3);
            calculator.Substract(2);

            // Assert
            Assert.AreEqual(1d, calculator.Result);
        }

        [Test]
        public void Clear_AfterCalculation_ReturnsZero()
        {
            // Arrange
            var calculator = new TestableCalculatorWithStaticLogger();

            // Act
            calculator.Add(1);
            calculator.Add(2);
            calculator.Clear();

            // Assert
            Assert.AreEqual(0d, calculator.Result);
        }

        /// <summary>
        /// A testable class of the CalculatorWithStaticLogger which overrides the call to the static logger component.
        /// This class is used in the unit tests instead of the CalculatorWithStaticLogger class.
        /// </summary>
        internal class TestableCalculatorWithStaticLogger : CalculatorWithStaticLogger
        {
            /// <summary>
            /// Call to StaticLogger is overridden to avoid a depency on the logger class.
            /// </summary>
            /// <param name="message"></param>
            protected override void CallStaticLogger(string message)
            {
                // Do nothing.
            }
        }
    }
}
