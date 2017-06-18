using System;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UsingMockFramework
{
    public class NotFoundUser : User
    {
        public NotFoundUser() : base (string.Empty, string.Empty, DateTime.MinValue)
        {
            Id = Guid.Empty;
        }
    }
}
