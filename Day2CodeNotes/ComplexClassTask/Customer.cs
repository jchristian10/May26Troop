using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClassTask
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Account SavingsAccount { get; set; }
        public Account CheckingAccount { get; set; }

        public Customer ()
        {
            this.SavingsAccount = new Account();
            this.CheckingAccount = new Account();
        }
    }
}
