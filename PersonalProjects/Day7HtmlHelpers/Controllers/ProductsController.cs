using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day7HtmlHelpers.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
    }

    public class State
    {
        public string Name { get; set; }
        public string StateCode { get; set; }
    }
}