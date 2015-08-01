using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Repository  //Creates a list of Movie and populates that list with movies!
    {
        public IList<Movie> ListMovies()
        {
            return new List<Movie>
            {
                new Movie{Title="Star Wars", Director="Lucas"},
                new Movie{Title="King Kong", Director="Jackson"},
                new Movie{Title="Memento", Director="Nolan"}    
            };
        }
    }
}