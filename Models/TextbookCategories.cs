﻿using System;
using System.Collections.Generic;

namespace TextbookFinder.Models
{
    public partial class TextbookCategories
    {
        public int TextbookId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Textbooks Textbook { get; set; }
    }
}
