using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextbookFinder.Models;

namespace TextbookFinder.Models.ViewModels
{
    public class TextbooksListViewModel
    {
        public IEnumerable<Textbooks> Textbooks { get; set; }
        public IEnumerable<TextbookPublishers> TextbookPublishers { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public Category CurrentCategory { get; set; }
    }  
}
