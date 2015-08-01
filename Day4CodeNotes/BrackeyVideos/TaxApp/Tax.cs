using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxApp
{
    public class Tax
    {

        public decimal Calculate(Person person, decimal amountToTax)
        {
           
            // if age < 5, taxAmount = 0
            if (person.Age < 5)
            {
                return 0;
            }
            
            // taxAmount cannot be negative

            //variable to store the amount of tax as we go
            decimal taxAmount = 0;

            // base tax 8%
            taxAmount = amountToTax * .08m;
            
            // thrusday Doubled
            if(DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                taxAmount = taxAmount * 2;
            }

            //fName
            if (person.FirstName.StartsWith("J"))
            {
                taxAmount = taxAmount * 2;
            }
            return taxAmount;

            //lName
            if (person.LastName.StartsWith("W"))
            {
                taxAmount = taxAmount - 1m;
            }
        }
    }
}
