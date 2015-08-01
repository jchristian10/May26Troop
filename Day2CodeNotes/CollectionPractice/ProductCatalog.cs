using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    class ProductCatalog
    {
        List<Product> products;

        public ProductCatalog()
        {
            products = new List<Product>();


            Product apple = new Product
                {
                    Id = "fruit_apple",
                    Name = "apple",
                    Price = 1.22m
                };
            Product laptop = new Product
                {
                    Id = "tech_laptop",
                    Name = "laptop",
                    Price = 392.99m
                };
            Product juice = new Product
                {
                    Id = "orane_juice",
                    Name = "juice",
                    Price = 2.25m
                };
        }

        public Product Lookup(string id)
        {
            return products.FristOrDefault(products => p.Id == id);
 
        }
    }
}
