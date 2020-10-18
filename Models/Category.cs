using System;
using System.Collections.Generic;

namespace TextbookFinder.Models
{
    public partial class Category
    {
        public Category()
        {
            TextbookCategories = new HashSet<TextbookCategories>();
            Textbooks = new HashSet<Textbooks>();
        }

        public int CategoryId { get; set; }
        public string Categories { get; set; }

        public virtual ICollection<TextbookCategories> TextbookCategories { get; set; }
        public virtual ICollection<Textbooks> Textbooks { get; set; }

    }
}
