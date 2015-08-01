using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer josh = new Customer
            {
                FirstName = "Josh",
                LastName = "Christiansen",
                CheckingAccount =
                {
                    Type = "Checking",
                    Id = "ChriJosChecking",
                    Amount = 34.23m,
                    IsOpen = true
                },
                SavingsAccount =
                {
                    Type = "Savings",
                    Id = "ChriJosSaving",
                    Amount = 0.12m,
                    IsOpen = false
                },
            };

            Console.ReadLine();
        }
    }
}
