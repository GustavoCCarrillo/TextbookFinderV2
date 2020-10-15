using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TextbookFinder.Models
{
    public partial class Textbooks
    {
        public Textbooks()
        {
            TextbookAuthors = new HashSet<TextbookAuthors>();
            TextbookCategories = new HashSet<TextbookCategories>();
        }

        public int TextbookId { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }
        public string Isbn { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int? PublisherId { get; set; }
        public int? CategoryId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }


        public virtual Category Category { get; set; }
        public virtual TextbookPublishers Publisher { get; set; }
        public virtual ICollection<TextbookAuthors> TextbookAuthors { get; set; }
        public virtual ICollection<TextbookCategories> TextbookCategories { get; set; }
    }
}
