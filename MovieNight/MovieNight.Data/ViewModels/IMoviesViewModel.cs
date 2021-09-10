using MovieNight.Data.Models;
using System.Collections.Generic;

namespace MovieNight.Data.ViewModels
{
    public interface IMoviesViewModel
    {
        IEnumerable<Movie> Movies { get; set; }
        string Name { get; set; }
        public int MoviesCount { get; set; }
    }
}