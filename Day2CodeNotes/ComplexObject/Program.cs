using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer josh = new Customer();
            josh.FirstName = "Joshua";
            josh.LastName = "Christiansen";
            
            josh.BillingAddress.Street = "1111 Neat Rd.";
            josh.BillingAddress.City = "Pearland";
            josh.BillingAddress.State = "Texas";
            josh.BillingAddress.Zip = "77584";


            Customer steve = new Customer
            {
                FirstName = "Steve",
                LastName = "Stroud",
                BillingAddress = 
                {
                    Street = "157 S. Quentin Rd",
                    City = "Palatine",
                    State = "Illinois",
                    Zip = "60067"
                },

                ShippingAddress = 
                {
                    Street = "1111 E. Easy St.",
                    City = "St Louis",
                    State = "MO",
                    Zip = "82729"
                }
                
                
            };
            
        }

    }
}

