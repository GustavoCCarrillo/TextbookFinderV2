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

        public void CreateTextbook(Textbooks t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public void DeleteTextbook(Textbooks t)
        {
            context.Remove(t);
            context.SaveChanges();
        }

        public void SaveTextbook(Textbooks t)
        {
            context.SaveChanges();
        }
    }
}
