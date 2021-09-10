using MovieNight.Data.Models;
using System.Collections.Generic;

namespace MovieNight.Data.Database
{
    public static class Database
    {
        public static IEnumerable<Actor> Actors { get; set; }
        public static IEnumerable<Movie> Movies { get; set; }   
    }
}
