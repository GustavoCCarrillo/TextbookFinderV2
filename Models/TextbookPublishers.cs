using System;
using System.Collections.Generic;

namespace TextbookFinder.Models
{
    public partial class TextbookPublishers
    {
        public TextbookPublishers()
        {
            Textbooks = new HashSet<Textbooks>();
        }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string PublisherWebsite { get; set; }

        public virtual ICollection<Textbooks> Textbooks { get; set; }
    }
}
