using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using ReadingTime3.Web.Controllers;
using Xunit;

namespace ReadingTime3.Web.Tests.Unit
{
    public class HomeControllerTests
    {
        [Fact]
        public void HomeControllerIndexViewTest()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void HomeControllerPrivacyViewTest()
        {
            const string expectedViewDataMessage = "This demo doesn't save any data, so we're all OK.";

            var controller = new HomeController();

            var result = controller.Privacy();

            var viewResult = Assert.IsType<ViewResult>(result);

            ViewDataDictionary viewDataDict = viewResult.ViewData;
            Assert.Equal(expectedViewDataMessage, viewDataDict["Message"]);
        }
    }
}
