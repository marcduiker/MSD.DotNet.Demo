using System;
using FluentAssertions;
using Moq;
using MSD.DotNet.Patterns.TestableCodeRefactoring.UsingMockFramework;
using MSD.DotNet.Patterns.TestableCodeRefactoring.UsingMockFramework.Users;
using NUnit.Framework;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UnitTests.UsingMockFramework
{
    [TestFixture]
    public class RegistrationServiceTests
    {
        [Test]
        public void RegisterUser_WithKnownUser_ReturnsUser()
        {
            // Arrange
            IUserRepository userRepository = UserRepositoryMockFactory.CreateWithKnownUser();
            var registrationService = GetRegistrationService(userRepository);

            // Act
            var result = registrationService.RegisterUser(
                name: It.IsAny<string>(),
                email: It.IsAny<string>(),
                dateOfBirth: It.IsAny<DateTime>());

            // Assert
            result.Should().BeOfType<User>();
        }

        [Test]
        public void RegisterUser_WithUnknownUser_ReturnsNewUser()
        {
            // Arrange
            IUserRepository userRepository = UserRepositoryMockFactory.CreateWithUnknownUser();
            var registrationService = GetRegistrationService(userRepository);

            // Act
            var result = registrationService.RegisterUser(
                name: It.IsAny<string>(),
                email: It.IsAny<string>(),
                dateOfBirth: It.IsAny<DateTime>());

            // Assert
            result.Should().BeOfType<NewUser>();
        }

        private static RegistrationService GetRegistrationService(IUserRepository userRepository)
        {
            return new RegistrationService(userRepository);
        }
    }
}
