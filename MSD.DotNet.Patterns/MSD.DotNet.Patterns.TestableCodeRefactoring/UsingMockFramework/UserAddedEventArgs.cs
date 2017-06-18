using System;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UsingMockFramework
{
    public class UserAddedEventArgs : EventArgs
    {
        public User User { get; set; }
    }
}
