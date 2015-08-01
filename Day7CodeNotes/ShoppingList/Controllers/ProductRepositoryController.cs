using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingList.Controllers
{
    public class ProductRepositoryController : Controller
    {
        // GET: ProductRepository
        public ActionResult Index()
        {
            ProductRepository repo = new ProductRepository();
            IList<Product> items = repo.GetItems();
            ProductsViewModel vm = new ProductsViewModel();
            vm.FirstName = "Josh";
            vm.LastName = "Christiansen";
            vm.Products = items;
            vm.Total = items.Sum(p => p.Price);

            return View(vm);
        }
    }
}