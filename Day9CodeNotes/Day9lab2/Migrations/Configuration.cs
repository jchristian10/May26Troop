namespace Day9lab2.Migrations
{
    using Day9lab2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Day9lab2.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Day9lab2.Models.MovieDBContext";
        }

        protected override void Seed(Day9lab2.Models.MovieDBContext context)
        {

            Movie[] movies = new Movie[]
            {
                new Movie {Title = "Star Wars", Director = "Lucas" },
                new Movie {Title = "Momento", Director = "Nolan" },
                new Movie {Title = "King King", Director = "Jackson" }
            };

            context.Movies.AddOrUpdate(m => m.Title, movies); //This is a one line forEach loop that adds each movie in the list to the database

            //foreach (Movie m in movies)
            ////{
            ////    context.Movies.Add(m);
            ////}


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
