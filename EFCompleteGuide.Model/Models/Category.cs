using System.ComponentModel.DataAnnotations;

namespace EFCompleteGuide.Model.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        public int Name { get; set; }
    }
}