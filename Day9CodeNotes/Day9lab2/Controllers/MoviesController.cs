using Day9lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day9lab2.Controllers
{
    public class MoviesController : Controller
    {
        //This is a private class instance variabl (or global class variable)
        private MovieDBContext _db = new MovieDBContext();
        
        // GET: Movies
        //This is a class method
        public ActionResult Index()
        {
            IQueryable<Movie> movies = from m in _db.Movies select m;
            return View(movies.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie); //Creates the concept of adding data to the database
                _db.SaveChanges();  //Actually adds the data to the database

                return RedirectToAction("Index");
            }

            return View();
        }
        public ActionResult Edit(int id)
        {
            Movie movie = _db.Movies.Find(id);
            
            return View(movie);
        }
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if(ModelState.IsValid)
            {
                //_db.Entry(movie).State = System.Data.Entity.EntityState.Modified;//This is not the best way to do this.  This is bad code
                Movie original = _db.Movies.Find(movie.Id);
                original.Title = movie.Title;
                original.Director = movie.Director;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            var movie = _db.Movies.Find(id);
            return View(movie);
        }
        [HttpPost]
        [ActionName("Delete")]

        public ActionResult DeleteReally(int id)
        {
            var original = _db.Movies.Find(id);
            _db.Movies.Remove(original);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        

    }
}