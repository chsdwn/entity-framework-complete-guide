using System.Collections.Generic;

namespace EFCompleteGuide.Model.Models
{
    public class FluentPublisher
    {
        public int Publisher_Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<Book> Books { get; set; }
    }
}