using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieNight.Data.Models;
using MovieNight.Data.ViewModels;

namespace MovieNight.Controllers
{
    public class ActorsController : Controller
    {
        public IActionResult Index()
        {
            var actorsList = new List<Actor>
            {
                new Actor
                {
                    Age = 23,
                    FirstName = "Gabi",
                    LastName = "kjasgfds"
                },
                new Actor
                {
                    Age = 12,
                    FirstName = "Bia",
                    LastName = "jsdglad"
                }
            };

            var viewModel = new ActorsViewModel
            {
                Actors = actorsList,
                AgeAverage = actorsList.Average(a => a.Age),
                Message = "Hi!"
            };

            return View(viewModel);
        }
    }
}