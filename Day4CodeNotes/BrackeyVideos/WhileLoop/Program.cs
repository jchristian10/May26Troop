using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfAttempts = 0;
            int attempt = 0;
            Random diceToss = new Random();

            while (attempt != 6)
            {
                attempt = diceToss.Next(1, 7);
                Console.WriteLine("You rolled a {0}", attempt);
                numberOfAttempts++;

            }

            Console.WriteLine("It took {0} attempts for you to roll a 6", numberOfAttempts);
            Console.ReadKey();
        }
    }
}
