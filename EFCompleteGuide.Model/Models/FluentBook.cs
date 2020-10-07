using System.Collections.Generic;

namespace EFCompleteGuide.Model.Models
{
    public class FluentBook
    {
        public int Book_Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }

        public int BookDetail_Id { get; set; }
        public BookDetail BookDetail { get; set; }

        public int Publisher_Id { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}