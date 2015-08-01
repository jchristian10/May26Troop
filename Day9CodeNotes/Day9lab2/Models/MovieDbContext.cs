using Day9lab2.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day9lab2.Models
{
    public class MovieDBContext : DbContext
    {


        static MovieDBContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieDBContext, Configuration>());
        }



        //the DbSet is an object that represents a repositiry!!!!
        //using the IDbSet interface gives you the .Add .Delete functions and so on
        public IDbSet<Movie> Movies { get; set; }
    }
}