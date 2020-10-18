using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TextbookFinder.Infrastructure;

namespace TextbookFinder.Models
{
    public class SessionCart : Cart 
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart")
                ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Textbooks textbook, int quantity)
        {
            base.AddItem(textbook, quantity);
            Session.SetJson("Cart", this);
        }

        public override void RemoveLine(Textbooks textbook)
        {
            base.RemoveLine(textbook);
            Session.SetJson("Cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
