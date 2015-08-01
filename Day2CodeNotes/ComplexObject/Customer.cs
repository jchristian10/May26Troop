using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexObject
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }


        public Customer()
        {
            this.BillingAddress = new Address();
            this.ShippingAddress = new Address();
        }
    
    }
}
