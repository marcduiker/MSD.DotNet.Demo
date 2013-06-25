namespace MSD.DotNet.Patterns.TestableCodePatterns.ExtractAndOverride
{
    public class CalculatorWithStaticLogger
    {
        private decimal _result;
        public decimal Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public void Add(decimal value)
        {
            CallStaticLogger(string.Format("Adding {0} to {1}.", value, _result));
            _result += value;
        }

        public void Substract(decimal value)
        {
            CallStaticLogger(string.Format("Substracting {0} from {1}.", value, _result));
            _result -= value;
        }

        public void Clear()
        {
            _result = 0;
        }

        /// <summary>
        /// Encapsulates the call to the StaticLogger in a protected virtual method.
        /// A TestableCalculator class can now be made (in the UnitTest project) 
        /// which inherits from this Calculator class and overrides the CallStaticLogger 
        /// method to break the dependency with the logger.
        /// </summary>
        /// <param name="message">Message to log.</param>
        protected virtual void CallStaticLogger(string message)
        {
            StaticLogger.Write(message);
        }
    }
}
