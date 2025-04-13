using Xunit;
using Microsoft.AspNetCore.Mvc;
using Group16_COMP367Project.Controllers;

namespace Group16_COMP367Project.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new HomeController(null);
            var result = controller.Index();
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName); // Using default view
        }

        [Fact]
        public void Privacy_Returns_ViewResult()
        {
            var controller = new HomeController(null);
            var result = controller.Privacy();
            Assert.IsType<ViewResult>(result);
        }
    }
}
