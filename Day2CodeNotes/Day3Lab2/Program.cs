using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                EndDate = null,
                StartDate = DateTime.Parse("2015-05-28"),
                Name = "Josh"
            };

            int years = emp.NumberOfYears.GetValueOrDefault(-10);  // must use .GetValueOrDefault on a nullable interger to convert the data back into an interger and sets a default

            emp.EndDate.GetValueOrDefualt(DateTime.Now);

        }
    }
}
