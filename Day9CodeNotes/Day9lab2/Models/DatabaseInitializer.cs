using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day9lab2.Models
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<MovieDBContext>
    {
        protected override void Seed(MovieDBContext context)
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie {Title = "Star Wars", Director = "Lucas" },
                new Movie {Title = "Momento", Director = "Nolan" },
                new Movie {Title = "King King", Director = "Jackson" }
            };

            movies.ForEach(m => context.Movies.Add(m)); //This is a one line forEach loop that adds each movie in the list to the database

            //foreach (Movie m in movies)
            ////{
            ////    context.Movies.Add(m);
            ////}
        }
    }
}