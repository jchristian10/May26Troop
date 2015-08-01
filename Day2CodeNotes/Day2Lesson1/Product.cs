using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lesson1
{
    class Product
    {
        public string Name { get; set; } //Class Property
        
        private decimal _price;  //Full Property

        public string Price
        {
            get { return _price.ToString("c"); }
            set { _price = decimal.Parse(value); }
        }
        
        //Class Property
        public decimal CalculateTax() //Class Method
        {
            return this._price * .085m;  //since _price is private I have to call it from a method within (not outside) the class
        }

        public decimal PriceWithTax() //Class Method
        {
            return this._price + (this._price * .085m);  //_price must be called locally because it is a private peremeter
        }

    }
}
