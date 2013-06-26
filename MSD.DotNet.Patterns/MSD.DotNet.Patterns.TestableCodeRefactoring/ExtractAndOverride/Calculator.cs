namespace MSD.DotNet.Patterns.TestableCodePatterns.ExtractAndOverride
{
    /// <summary>
    /// Calculator class which uses a static Logger class inside a protected virtual method.
    /// </summary>
    public class Calculator
    {
        private decimal _result;
        public decimal Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public void Add(decimal value)
        {
            WriteToStaticLogger(string.Format("Adding {0} to {1}.", value, _result));
            _result += value;
        }

        public void Substract(decimal value)
        {
            WriteToStaticLogger(string.Format("Substracting {0} from {1}.", value, _result));
            _result -= value;
        }

        public void Clear()
        {
            _result = 0;
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
