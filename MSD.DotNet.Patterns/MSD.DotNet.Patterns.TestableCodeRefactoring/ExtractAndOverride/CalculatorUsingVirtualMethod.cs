namespace MSD.DotNet.Patterns.TestableCodeRefactoring.ExtractAndOverride
{
    /// <summary>
    /// Calculator class which uses a static Logger class inside a protected virtual method.
    /// </summary>
    public class Calculator
    {
        public decimal Value { get; set; }

        public void Add(decimal value)
        {
            WriteToStaticLogger($"Adding {value} to {Value}.");
            Value += value;
        }

        public void Substract(decimal value)
        {
            WriteToStaticLogger($"Substracting {value} from {Value}.");
            Value -= value;
        }

        public void Clear()
        {
            Value = 0;
        }

        /// <summary>
        /// Encapsulates the call to the StaticLogger in a protected virtual method.
        /// A testable class can now be made (in the UnitTest project) which inherits 
        /// from this Calculator class and overrides the CallStaticLogger method 
        /// to break the dependency with the logger.
        /// </summary>
        /// <param name="message">Message to log.</param>
        protected virtual void WriteToStaticLogger(string message)
        {
            StaticLogger.Write(message);
        }
    }
}
