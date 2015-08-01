using HushHush.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HushHush.Controllers
{
    public class PostsController : Controller
    {

        private DataContext _db = new DataContext();

        // GET: Movies
        public ActionResult Index()
        {
            var posts= from p in _db.Posts select p;
            return View(posts.ToList());
        }

        // GET: Posts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Posts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        [HttpPost]
        public ActionResult Create(Post post)
        {
            try
            {
                // TODO: Add insert logic here
                if(ModelState.IsValid)
                {
                    _db.Posts.Add(post);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int id)
        {
            var post = _db.Posts.Find(id);
            return View(post);
        }

        // POST: Posts/Edit/5
        [HttpPost]
        public ActionResult Edit(Post post)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(post).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int id)
        {
            var post = _db.Posts.Find(id);
            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            var original = _db.Posts.Find(id);
            _db.Posts.Remove(original);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
