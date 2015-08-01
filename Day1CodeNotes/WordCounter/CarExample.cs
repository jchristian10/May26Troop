using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    public abstract class Car //would mean that nobody would ever create this without making one of its inheratants.
    {
        public string Vin { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

    }
    public class NewCar : Car
    {

    }
    public class UsedCar : newCar //Inherit Properties from Car
    {
        public int Miles { get; set; }
    }

    public class CertifiedUsedCar : UsedCar // Inherits from UsedCar which inherits from Car
    {
        public int WarrantyMonths { get; set; }
    }

}