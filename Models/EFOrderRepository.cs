using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace TextbookFinder.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private TextbooksDBContext context;

        public EFOrderRepository(TextbooksDBContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Order> Orders => context.Orders
            .Include(o => o.Lines)
            .ThenInclude(l => l.Textbook);

        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Textbook));
            if (order.OrderId == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Textbook));
            if (order.OrderId != 0)
            {
                context.Orders.Remove(order);
            }
            context.SaveChanges();
        }
    }
}
