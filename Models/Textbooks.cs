using System;
using System.Collections.Generic;

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

        public virtual Category Category { get; set; }
        public virtual TextbookPublishers Publisher { get; set; }
        public virtual ICollection<TextbookAuthors> TextbookAuthors { get; set; }
        public virtual ICollection<TextbookCategories> TextbookCategories { get; set; }
    }
}
