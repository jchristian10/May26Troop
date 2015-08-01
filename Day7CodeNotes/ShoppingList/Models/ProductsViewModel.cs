using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class ProductsViewModel
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public decimal Total { get; set; }

        public IList<Product> Products { get; set; }

    }
}