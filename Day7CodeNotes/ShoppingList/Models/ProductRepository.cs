using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class ProductRepository
    {
        private IList<Product> _products = new List<Product>();  //instanciating an object.  IS NOT THE DO'ER!


        public IList<Product> GetItems()
        {
            _products.Add(new Product { Name = "Kleenex", Price = 5m });
            _products.Add(new Product { Name = "Socks", Price = 4m });
            return _products;
        }

    }
}