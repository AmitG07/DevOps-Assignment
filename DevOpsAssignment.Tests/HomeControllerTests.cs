using DevOpsAssignment.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DevOpsAssignment.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Get_ReturnsOkResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Get() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal("Welcome to Home Controller", result.Value);
        }
    }
}