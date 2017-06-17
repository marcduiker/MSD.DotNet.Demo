using MSD.DotNet.Patterns.TestableCodeRefactoring.ExtractAndOverride;

namespace MSD.DotNet.Patterns.TestableCodePatterns.UnitTests.ExtractAndOverride
{
    /// <summary>
    /// A testable class of the Calculator which overrides the call to the static logger component.
    /// This class is used in the unit tests instead of the CalculatorWithStaticLogger class.
    /// </summary>
    internal class TestableCalculator : Calculator
    {
        /// <summary>
        /// Call to StaticLogger is overridden to avoid a dependency on the logger class.
        /// </summary>
        /// <param name="message"></param>
        protected override void WriteToStaticLogger(string message)
        {
            // Do nothing.
        }
    }
}
