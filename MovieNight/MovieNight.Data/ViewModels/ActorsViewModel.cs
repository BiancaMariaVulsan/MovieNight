using MovieNight.Data.Models;
using System.Collections.Generic;

namespace MovieNight.Data.ViewModels
{
    public class ActorsViewModel : IActorsViewModel
    {
        public IEnumerable<Actor> Actors { get; set; }
        public string Message { get; set; }
        public double AgeAverage { get; set; }
    }
}
