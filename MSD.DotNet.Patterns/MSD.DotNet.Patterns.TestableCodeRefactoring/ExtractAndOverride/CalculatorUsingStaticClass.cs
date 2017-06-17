namespace MSD.DotNet.Patterns.TestableCodeRefactoring.ExtractAndOverride
{
    /// <summary>
    /// Calculator class which uses a static Logger class inside a protected virtual method.
    /// </summary>
    public class CalculatorUsingStaticClass
    {
        public decimal Value { get; set; }

        public void Add(decimal value)
        {
            StaticLogger.Write($"Adding {value} to {Value}.");
            Value += value;
        }

        public void Substract(decimal value)
        {
            StaticLogger.Write($"Substracting {value} from {Value}.");
            Value -= value;
        }

        public void Clear()
        {
            Value = 0;
        }
    }
}
