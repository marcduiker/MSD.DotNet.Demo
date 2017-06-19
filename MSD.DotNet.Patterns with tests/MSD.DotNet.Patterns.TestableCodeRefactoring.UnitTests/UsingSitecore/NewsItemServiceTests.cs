using FluentAssertions;
using MSD.DotNet.Patterns.TestableCodeRefactoring.UsingSitecore;
using NUnit.Framework;

namespace MSD.DotNet.Patterns.TestableCodeRefactoring.UnitTests.UsingSitecore
{
    [TestFixture]
    public class NewsItemServiceTests
    {
        [Test]
        public void GetNewsItems_WithInvalidNewsRoot_ReturnsEmptyList()
        {
            // Arrange
            var newsItemService = new NewsItemService();
            using (var db = FakeDbFactory.CreateDbWithoutNewsRoot())
            {
                // Act
                var result = newsItemService.GetNewsItems();

                // Assert
                result.Should().BeEmpty();
            }
        }

        [Test]
        public void GetNewsItems_WithValidNewsRootAndNoNewsItems_ReturnsEmptyList()
        {
            // Arrange
            var newsItemService = new NewsItemService();
            using (var db = FakeDbFactory.CreateDbWithNewsRootAndWithoutNewsItems())
            {

                // Act
                var result = newsItemService.GetNewsItems();

                // Assert
                result.Should().BeEmpty();
            }
        }

        [Test]
        public void GetNewsItems_WithValidNewsRootAndNewsItems_ReturnsNewsItems()
        {
            // Arrange
            var newsItemService = new NewsItemService();
            using (var db = FakeDbFactory.CreateDbWithNewsRootAndWithNewsItems())
            {
                // Act
                var result = newsItemService.GetNewsItems();

                // Assert
                result.Should().NotBeEmpty();
            }
        }
    }
}
