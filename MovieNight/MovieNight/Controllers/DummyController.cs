using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieNight.Controllers
{
    public class DummyController : Controller
    {
        public IActionResult Index()
        {
            //This does nothing...
            return View();
        }
    }
}
