using ReadingTime3.Web.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace ReadingTime3.Web.Tests.Unit
{
    public class BookTests
    {
        [Fact]
        public void TestEmptyBookConstructor()
        {
            Book book = new Book();
            Assert.NotNull(book);
        }

        [Fact]
        public void TestBookConstructor()
        {
            Book book = new Book("Crossing the Chasm", "Geoffrey A.Moore");
            Assert.Equal("Geoffrey A.Moore", book.Author);
            Assert.Equal("Crossing the Chasm", book.Title);
        }

        [Fact]
        public void ConstructorWithCoverTest()
        {
            Book book = new Book("Crossing the Chasm", "Geoffrey A.Moore", "cover.jpg");
            Assert.Equal("cover.jpg", book.Cover);
        }

        [Fact]
        public void ExpectValidBookModelState()
        {
            Book book = new Book("Crossing the Chasm", "Geoffrey A.Moore");
            var context = new ValidationContext(book, null, null);
            var result = new List<ValidationResult>();

            var valid = Validator.TryValidateObject(book, context, result, true);

            Assert.True(valid);

        }

        [Theory]
        [InlineData("a")]
        [InlineData("ab")]
        [InlineData("ababababababababababababababababababababababababababababababa")]
        public void ExpectInvalidBookAuthorModelState(string author)
        {
            Book book = new Book("Crossing the Chasm", author);
            var context = new ValidationContext(book, null, null);
            var result = new List<ValidationResult>();

            var valid = Validator.TryValidateObject(book, context, result, true);

            Assert.False(valid);

        }

        [Theory]
        [InlineData("a")]
        [InlineData("ab")]
        public void ExpectInvalidBookTitleModelState(string title)
        {
            Book book = new Book(title, "Geoffrey A.Moore");
            var context = new ValidationContext(book, null, null);
            var result = new List<ValidationResult>();

            var valid = Validator.TryValidateObject(book, context, result, true);

            Assert.False(valid);

        }

    }
}
