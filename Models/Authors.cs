using System;
using System.Collections.Generic;

namespace TextbookFinder.Models
{
    public partial class Authors
    {
        public Authors()
        {
            TextbookAuthors = new HashSet<TextbookAuthors>();
        }

        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<TextbookAuthors> TextbookAuthors { get; set; }
    }
}
