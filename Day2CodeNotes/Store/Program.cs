using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Product myProduct = new Product();
            
            myProduct.Type = "Candy";
            myProduct.Price = 12.65m;
            myProduct.Quantity = 3;

            var props = myProduct.GetType().GetProperties();

            for (int i = 0; i < props.Length; i++ )
            {
                Console.WriteLine("Property: {0}, Valie{1}", props.Name, props.GetValue(myProduct));
            }



                Console.WriteLine(myProduct.Type);
            Console.ReadLine();

            
        }
    }
}
