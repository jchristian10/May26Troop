using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product  //Creates the product
            {
                Name = "Apples",  //Initializes the Name property
                Price = "11.23"    //Initializes the Price property
            };
            //Display Products
            Console.WriteLine("Name: {0}, Price: {1}", product.Name, product.Price);
            Console.WriteLine("The tax on {0} will be {1}", product.Name, product.CalculateTax());
            Console.WriteLine("The total cost of {0} after tax will be {1}", product.Name, product.PriceWithTax());
            Console.ReadLine();
        }
    }
}
