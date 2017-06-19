using FakeItEasy;
using Moq;
using MSD.DotNet.Patterns.TestableCodeRefactoring.UsingInterfaces;
using NUnit.Framework;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UnitTests.UsingMockFramework
{
    [TestFixture]
    public class CalculatorWithMockFrameworkTests
    {
        [Test]
        public void WriteToLog_WhenAddingANumber_WriteToLogMustHaveHappened_UsingFakeItEasy()
        {
            // Arrange
            ILogger fakeLogger = A.Fake<ILogger>();
            var calculator = new Calculator(fakeLogger);

            // Act
            calculator.Add(1);

            // Assert
            A.CallTo(() => fakeLogger.Write(A<string>.Ignored)).MustHaveHappened(Repeated.Exactly.Once);
        }

        [Test]
        public void WriteToLog_WhenAddingANumber_WriteToLogMustHaveHappened_UsingMoq()
        {
            // Arrange
            var fakeLogger = new Mock<ILogger>();
            var calculator = new Calculator(fakeLogger.Object);

            // Act
            calculator.Add(1);

            // Assert
            fakeLogger.Verify(fake => fake.Write(It.IsAny<string>()), Times.Once);
        }
    }
}
