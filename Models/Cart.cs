using System.Collections.Generic;
using System.Linq;

namespace TextbookFinder.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Textbooks textbook, int quantity)
        {
            CartLine line = Lines
                .Where(t => t.Textbook.TextbookId == textbook.TextbookId)
                .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Textbook = textbook,
                    Quantity = quantity
                });
            } else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Textbooks textbook) =>
            Lines.RemoveAll(l => l.Textbook.TextbookId == textbook.TextbookId);

        public decimal ComputeTotalValue() =>
            Lines.Sum(e => e.Textbook.Price * e.Quantity);

        public virtual void Clear() => Lines.Clear();
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Textbooks Textbook { get; set; }
        public int Quantity { get; set; }

    }
}
