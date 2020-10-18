using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TextbookFinder.Infrastructure;
using TextbookFinder.Models;
using System.Linq;

namespace TextbookFinder.Pages
{
    public class CartModel : PageModel
    {
        private ITextbookRepository repository;
        public CartModel(ITextbookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int textbookId, string returnUrl)
        {
            Textbooks textbook = repository.Textbook
                .FirstOrDefault(t => t.TextbookId == textbookId);
            Cart.AddItem(textbook, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int textbookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
            cl.Textbook.TextbookId == textbookId).Textbook);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
