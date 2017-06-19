using System;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UsingMockFramework.Users
{
    public class NewUser : User
    {
        public NewUser(
            string name,
            string email,
            DateTime dateOfBirth) : 
            base(name,
                email,
                dateOfBirth
            )
        {
        }
    }
}
