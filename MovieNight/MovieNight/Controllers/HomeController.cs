using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieNight.Models;
using System.Collections.Generic;

namespace MovieNight.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
