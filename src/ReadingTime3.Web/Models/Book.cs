using System.ComponentModel.DataAnnotations;

namespace ReadingTime3.Web.Models
{
    public class Book
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Author { get; set; }
        public string Cover { get; set; }

        public Book()
        {

        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public Book(string title, string author, string cover)
        {
            Title = title;
            Author = author;
            Cover = cover;
        }

    }

}
