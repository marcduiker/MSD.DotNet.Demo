using MSD.DotNet.Patterns.TestableCodeRefactoring.UsingInterfaces;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UnitTests.UsingInterfaces
{
    /// <summary>
    /// A hand coded fake logger class to use in unit tests on classes that use the ILogger interface.
    /// </summary>
    public class FakeLogger : ILogger
    {
        public void Write(string message)
        {
            // Do nothing.
        }
    }
}
