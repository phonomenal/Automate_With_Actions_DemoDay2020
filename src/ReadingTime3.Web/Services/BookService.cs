using System.Collections.Generic;
using ReadingTime3.Web.Models;

namespace ReadingTime3.Web.Services
{
    public class BookService
    {
        private readonly List<Book> books = new List<Book>
        {
            new Book("Accelerate: The Science of Lean Software and DevOps: Building and Scaling High Performing Technology Organizations", "Nicole Forsgren, PhD", "forsgren.jpg"),
            new Book("Scrum: The Art of Doing Twice the Work in Half the Time", "Jeff Sutherland", "scrum.jpg"),
            new Book("The Lean Startup: How Constant Innovation Creates Radically Successful Businesses","Eric Ries", "lean.jpg"),
            new Book("Crossing the Chasm", "Geoffrey A. Moore", "chasm.jpg"),
            new Book("The Pragmatic Programmer: From Journeyman to Master", "David Thomas", "pragmatic.jpg"),
            new Book("Don't Make Me Think, Revisited: A Common Sense Approach to Web Usability"," Steve Krug", "think.jpg")
        };

        public List<Book> Books() => books;
    }
}
