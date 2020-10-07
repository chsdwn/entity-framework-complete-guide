
namespace EFCompleteGuide.Model.Models
{
    public class FluentBookAuthor
    {
        public int Book_Id { get; set; }
        public Book Book { get; set; }

        public int Author_Id { get; set; }
        public Author Author { get; set; }
    }
}