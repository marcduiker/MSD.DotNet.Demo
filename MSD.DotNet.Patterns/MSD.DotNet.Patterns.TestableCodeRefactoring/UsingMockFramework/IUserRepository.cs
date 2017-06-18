using System;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UsingMockFramework
{
    public interface IUserRepository
    {
        event EventHandler<UserAddedEventArgs> UserAdded;

        User Get(string name);

        User Add(User user);
    }
}