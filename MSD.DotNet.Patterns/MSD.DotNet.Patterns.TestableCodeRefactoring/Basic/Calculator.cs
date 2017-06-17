namespace MSD.DotNet.Patterns.TestableCodeRefactoring.Basic
{
    /// <summary>
    /// Basic Calculator class without any dependencies.
    /// </summary>
    public class Calculator
    {
        public decimal Value { get; set; }

        public void Add(decimal value)
        {
            Value += value;
        }

        public void Substract(decimal value)
        {
            Value -= value;
        }

        public void Clear()
        {
            Value = 0;
        }
    }
}
