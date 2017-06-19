namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UsingInterfaces
{
    /// <summary>
    /// Calculator class which uses the ILogger interface through constructor injection.
    /// </summary>
    public class Calculator
    {
        private readonly ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public decimal Result { get; set; }

        public void Add(decimal value)
        {
            _logger.Write($"Adding {value} to {Result}.");
            Result += value;
        }

        public void Substract(decimal value)
        {
            _logger.Write($"Substracting {value} from {Result}.");
            Result -= value;
        }

        public void Clear()
        {
            _logger.Write("Clear result.");
            Result = 0;
        }
    }
}
