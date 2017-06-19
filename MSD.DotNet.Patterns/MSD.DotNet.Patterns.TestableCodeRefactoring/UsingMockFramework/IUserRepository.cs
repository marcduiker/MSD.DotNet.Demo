using System;
using MSD.DotNet.Patterns.TestableCodeRefactoring.UsingMockFramework.Users;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UsingMockFramework
{
    public interface IUserRepository
    {
        event EventHandler<UserAddedEventArgs> UserAdded;

        User Get(string email);

        NewUser Add(
            string name,
            string email,
            DateTime dateOfBirth);

        bool IsKnownUser(string email);
    }
}