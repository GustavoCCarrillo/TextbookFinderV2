using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TextbookFinder.Models;

namespace TextbookFinder.Controllers
{
    public class HomeController : Controller
    {
        private ITextbookRepository repository;

        public HomeController(ITextbookRepository repo)
        {
            repository = repo;

        }

        public IActionResult Index() => View(repository.Textbook);


        //private readonly ILogger<HomeController> _logger;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;

        //}
    }
}
