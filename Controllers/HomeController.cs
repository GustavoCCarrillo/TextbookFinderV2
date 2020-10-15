using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TextbookFinder.Models;
using TextbookFinder.Models.ViewModels;

namespace TextbookFinder.Controllers
{
    public class HomeController : Controller
    {
        private ITextbookRepository repository;
        public int PageSize = 5;

        public HomeController(ITextbookRepository repo)
        {
            repository = repo;

        }

        // public IActionResult Index() => View(repository.Textbook);

        public ViewResult Index(string category, int textbookPage = 1)
            => View(new TextbooksListViewModel
            { Textbooks = repository.Textbook
                //.AsEnumerable()
                .Where(t => category == null || t.Category.Categories == category)
                .OrderBy(t => t.TextbookId)
                .Skip((textbookPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = textbookPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Textbook.Count()
                }
            });
    }
}
