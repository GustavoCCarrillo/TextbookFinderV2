using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextbookFinder.Models
{
    public interface ITextbookRepository
    {
        IQueryable<Textbooks> Textbook { get; }
        IQueryable<TextbookPublishers> TextbookPublishers { get; }

        void SaveTextbook(Textbooks t);
        void CreateTextbook(Textbooks t);
        void DeleteTextbook(Textbooks t);
    }
}
