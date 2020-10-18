using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextbookFinder.Models;

namespace TextbookFinder.Components
{
    public class NavigationMenuViewComponent : ViewComponent 
    {
        private ITextbookRepository repository;
        public NavigationMenuViewComponent(ITextbookRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Textbook
                .Select(c => c.Category)
                .Distinct()
                .OrderBy(c => c));
        }
    }
}
