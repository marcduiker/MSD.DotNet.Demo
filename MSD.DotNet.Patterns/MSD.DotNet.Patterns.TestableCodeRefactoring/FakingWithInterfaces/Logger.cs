namespace MSD.DotNet.Patterns.TestableCodePatterns.FakingWithInterfaces
{
    using System;

    /// <summary>
    /// Logger class which implements the ILogger interface.
    /// </summary>
    public class Logger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
