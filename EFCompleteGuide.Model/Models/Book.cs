using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCompleteGuide.Model.Models
{
    public class Book
    {
        [Key]
        public int Book_Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(15)]
        public string ISBN { get; set; }
        [Required]
        public double Price { get; set; }

        [ForeignKey(nameof(BookDetail))]
        public int BookDetail_Id { get; set; }
        public BookDetail BookDetail { get; set; }

        [ForeignKey(nameof(Publisher))]
        public int Publisher_Id { get; set; }
        public Publisher Publisher { get; set; }
    }
}