using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieNight.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            int a = 7;
            a++;
            Console.WriteLine($"a = {a}");
            return View();
        }

        public int ReturnSmth()
        {
            Console.WriteLine(" I don't know what I am doing...");
            return -4;
        }
    }
}
