using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] {"Mars Attacks!", "Seahawks Win Superbowl!", "Bears Greatest NFL Frahchise!"};
            Console.WriteLine(stringArray.randomizeItem());
            Console.ReadLine();
            int[] intArray = new int[] { 1, 4, 5, 2, 5, 6 };
            Console.WriteLine(intArray.randomizeItem());
            Console.ReadLine();
        }
    }
}
