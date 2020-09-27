using System;
using System.Collections.Generic;

namespace TextbookFinder.Models
{
    public partial class TextbookAuthors
    {
        public int TextbookId { get; set; }
        public int AuthorId { get; set; }

        public virtual Authors Author { get; set; }
        public virtual Textbooks Textbook { get; set; }
    }
}
