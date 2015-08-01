using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a date and time...");
            var dateEntered = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("The date you entered was {0}", dateEntered);
            Console.ReadLine();
        }
    }
}
