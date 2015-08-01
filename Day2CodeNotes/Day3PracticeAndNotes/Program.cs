using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3PracticeAndNotes
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee alex = new Employee();
            {
                alex.FirstName = "alex";
                alex.LastName = "Isaac";
            
            }

            Employee[] employeeArray = new Employee[] { alex, new Employee { FirstName = "Nick", LastName = "Brittain" } };

            Array.Sort(employeeArray, new LastFirstComparer() );
            foreach (var employee in employeeArray)
            {
                Console.WriteLine(employee.LastName + ", " + employee.FirstName);
            }
            Console.ReadLine();
        }


        //            var colors = new string[] { "Red", "Green", "Blue" };
        //          Array.Sort(colors);
        //
        //            foreach (var color in colors)
        //            {
        //                Console.WriteLine(color);
        //            }
        //
        //            Console.ReadLine();
    }
}

