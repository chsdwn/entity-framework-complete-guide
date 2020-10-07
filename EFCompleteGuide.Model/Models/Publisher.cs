using System.ComponentModel.DataAnnotations;

namespace EFCompleteGuide.Model.Models
{
    public class Publisher
    {
        [Key]
        public int Publisher_Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
    }
}