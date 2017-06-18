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
    }
}
