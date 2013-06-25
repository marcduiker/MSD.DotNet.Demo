namespace MSD.DotNet.Patterns.TestableCodePatterns.ExtractAndOverride
{
    using System;

    /// <summary>
    /// Static logger class, exists only for demonstration purposes.
    /// The idea is that calls to this class should be prevented in unit tests
    /// since a logging component could access external components such as the 
    /// file system, a database or the EventLog.
    /// </summary>
    public static class StaticLogger
    {
        public static void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
