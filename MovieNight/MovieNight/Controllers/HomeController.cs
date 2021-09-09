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
            var moviesList = new List<Movie>()
            {
                new Movie
                {
                    Title = "Me Before You",
                    ReleaseYear = 2020
                },
                new Movie
                {
                    Title = "Chappie",
                    ReleaseYear = 2016
                }, 
                new Movie
                {
                    Title = "Butterfly Effect",
                    ReleaseYear = 2005
                }
            };

            return View(moviesList);
        }
    }
}
