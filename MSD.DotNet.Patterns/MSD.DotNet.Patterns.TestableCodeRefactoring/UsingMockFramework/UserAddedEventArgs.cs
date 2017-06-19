using System;
using MSD.DotNet.Patterns.TestableCodeRefactoring.UsingMockFramework.Users;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UsingMockFramework
{
    public class UserAddedEventArgs : EventArgs
    {
        public User User { get; set; }
    }
}
