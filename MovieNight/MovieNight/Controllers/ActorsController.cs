using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieNight.Data.Database;
using MovieNight.Data.Models;

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


            Database.Actors = actorsList;
            return View();
        }
    }
}