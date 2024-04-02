using DevOpsAssignment.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DevOpsAssignment.Tests
{
    public class AboutControllerTests
    {
        [Fact]
        public void Get_ReturnsOkResult()
        {
            // Arrange
            var controller = new AboutController();

            // Act
            var result = controller.Get() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal("Welcome to About Controller", result.Value);
        }
    }
}