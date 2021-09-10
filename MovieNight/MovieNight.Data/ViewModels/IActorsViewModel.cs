using MovieNight.Data.Models;
using System.Collections.Generic;

namespace MovieNight.Data.ViewModels
{
    public interface IActorsViewModel
    {
        IEnumerable<Actor> Actors { get; set; }
        double AgeAverage { get; set; }
        string Message { get; set; }
    }
}