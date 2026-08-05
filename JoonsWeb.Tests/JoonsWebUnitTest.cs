using JoonsWeb.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace JoonsWeb.Tests;

public class JoonsWebUnitTest
{
    [Fact]
    public void Index_ReturnsAViewResult()
        {
            // 1. Arrange - Setup your controller instances and data
            var controller = new HomeController();

            // 2. Act - Execute the method you are testing
            var result = controller.Index();

            // 3. Assert - Verify the outcome matches expectations
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
        }
}
