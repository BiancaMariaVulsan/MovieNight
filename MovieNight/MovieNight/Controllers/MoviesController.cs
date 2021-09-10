using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieNight.Data.Database;
using MovieNight.Data.Models;
using MovieNight.Data.ViewModels;

namespace MovieNight.Controllers
{
    public class MoviesController : Controller
    {
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
                }
            };

            var viewModel = new MoviesViewModel
            {
                Movies = moviesList,
                Name = "Bia",
                MoviesCount = moviesList.Count
            };

            return View(viewModel);
        }
    }
}