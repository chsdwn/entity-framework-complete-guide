using System.ComponentModel.DataAnnotations.Schema;

namespace EFCompleteGuide.Model.Models
{
    public class BookAuthor
    {
        [ForeignKey(nameof(Book))]
        public int Book_Id { get; set; }
        public Book Book { get; set; }

        [ForeignKey(nameof(Author))]
        public int Author_Id { get; set; }
        public Author Author { get; set; }
    }
}