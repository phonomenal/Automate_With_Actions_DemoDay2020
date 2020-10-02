using Microsoft.AspNetCore.Mvc;
using ReadingTime3.Web.Controllers;
using ReadingTime3.Web.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ReadingTime3.Web.Tests.Unit
{
    public class BookControllerTests
    {
        [Fact]
        public void BookControllerViewAndModelTest()
        {
            var controller = new BookController();

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);

            var books = Assert.IsAssignableFrom<IEnumerable<Book>>(
                viewResult.ViewData.Model);
            Assert.Equal(6, books.Count());
        }
    }
}
