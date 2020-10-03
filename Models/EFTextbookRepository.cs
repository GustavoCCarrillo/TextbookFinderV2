using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextbookFinder.Models
{
    public class EFTextbookRepository : ITextbookRepository
    {
        private TextbooksDBContext context;
        public EFTextbookRepository(TextbooksDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Textbooks> Textbook => context.Textbooks;
        public IQueryable<TextbookPublishers> TextbookPublishers => context.TextbookPublishers;
    }
}
