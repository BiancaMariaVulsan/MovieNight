using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MovieNight.Data.Models;
using MovieNight.Data.ViewModels;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MovieNight.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IConfiguration _configuration;

        public MoviesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            string connectionString = _configuration.GetConnectionString("moviesDbConnectionString");
            var connection = new SqlConnection
            {
                ConnectionString = connectionString
            };

            var selectAllMoviesCommand = new SqlCommand
            {
                CommandText = "SELECT * FROM Movie",
                Connection = connection
            };

            var moviesList = new List<Movie>();

            connection.Open();
            using (var reader = selectAllMoviesCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var movie = new Movie
                    {
                        Id = int.Parse(reader[0].ToString()),
                        Title = reader[1].ToString(),
                        ReleaseYear = int.Parse(reader[2].ToString())
                    };

                    moviesList.Add(movie);
                }
            }
            connection.Close();

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