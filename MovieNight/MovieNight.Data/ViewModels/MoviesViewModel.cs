using MovieNight.Data.Models;
using System.Collections.Generic;

namespace MovieNight.Data.ViewModels
{
    public class MoviesViewModel : IMoviesViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public string Name { get; set; }
        public int MoviesCount { get; set; }
    }
}
