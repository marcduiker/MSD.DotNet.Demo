using MSD.DotNet.Patterns.TestableCodeRefactoring.FakingWithInterfaces;

namespace MSD.DotNet.Patterns.TestableCodePatterns.UnitTests.FakingWithInterfaces
{
    using FakeItEasy;
    using NUnit.Framework;

    /// <summary>
    /// Class with unit tests for the Calculator which uses the ILogger interface.
    /// Modify the GetCalculator method to either return a handcoded FakeLogger 
    /// or a fake logger that is created by the FakeItEasy library (https://github.com/FakeItEasy/FakeItEasy).
    /// </summary>
    [TestFixture]
    public class CalculatorWithILoggerTests
    {
        [Test]
        public void Add_SingleNumber_ReturnsTheSameNumber()
        {
            // Arrange
            var calculator = GetCalculator();

            // Act
            calculator.Add(1);

            // Assert
            Assert.AreEqual(1d, calculator.Result);
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
            Assert.AreEqual(3d, calculator.Result);
        }

        [Test]
        public void Substract_SinglePositiveNumber_ReturnsTheNegativeOfTheNumber()
        {
            // Arrange
            var calculator = GetCalculator();

            // Act
            calculator.Substract(1);

            // Assert
            Assert.AreEqual(-1d, calculator.Result);
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
            Assert.AreEqual(1d, calculator.Result);
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
            Assert.AreEqual(0d, calculator.Result);
        }

        [Test]
        public void WriteToLog_WhenAddingANumber_WriteToLogMustHaveHappened()
        {
            // Arrange
            ILogger fakeLogger = A.Fake<ILogger>();
            var calculator = new Calculator(fakeLogger);

            // Act
            calculator.Add(1);

            // Assert
            A.CallTo(() => fakeLogger.Write(A<string>.Ignored)).MustHaveHappened(Repeated.Exactly.Once);
        }

        private Calculator GetCalculator()
        {
            #region using a handcoded fake

            // ILogger fakeLogger = new FakeLogger();

            #endregion

            #region using FakeItEasy

            ILogger fakeLogger = A.Fake<ILogger>();

            #endregion

            return new Calculator(fakeLogger);


        }
    }
}
