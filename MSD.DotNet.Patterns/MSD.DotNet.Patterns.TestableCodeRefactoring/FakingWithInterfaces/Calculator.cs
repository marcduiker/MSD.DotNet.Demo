namespace MSD.DotNet.Patterns.TestableCodePatterns.FakingWithInterfaces
{
    /// <summary>
    /// Calculator class which uses the ILogger interface through constructor injection.
    /// </summary>
    public class Calculator
    {
        private readonly ILogger _logger;
        private decimal _result;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public decimal Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public void Add(decimal value)
        {
            _logger.Write(string.Format("Adding {0} to {1}.", value, _result));
            _result += value;
        }

        public void Substract(decimal value)
        {
            _logger.Write(string.Format("Substracting {0} from {1}.", value, _result));
            _result -= value;
        }

        public void Clear()
        {
            _logger.Write("Clear result.");
            _result = 0;
        }
    }
}
