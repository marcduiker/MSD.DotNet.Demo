using System;
using MSD.DotNet.Patterns.TestableCodeRefactoring.UsingMockFramework.Users;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UsingMockFramework
{
    public class RegistrationService
    {
        private readonly IUserRepository _userRepository;

        public RegistrationService(
            IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User RegisterUser(
            string name,
            string email,
            DateTime dateOfBirth)
        {

            if (_userRepository.IsKnownUser(email))
            {
                return _userRepository.Get(email);
            }

            return _userRepository.Add(name, email, dateOfBirth);
        }
    }
}
