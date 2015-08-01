using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the first number
            Console.WriteLine("Please enter the first number");
            var firstNum = 0; 
            var firstNumIsNumber = int.TryParse(Console.ReadLine(), out firstNum);
            
            //get the second number
            Console.WriteLine("Please enter the second number");
            var secondNum = 0;
            var secondNumIsNumber = int.TryParse(Console.ReadLine(), out secondNum);

            if (firstNumIsNumber == true && secondNumIsNumber == true)
            {
                var sum = firstNum + secondNum;
                Console.WriteLine("The result is {0}", sum);
            }
            else
            {
                Console.WriteLine("You did not enter a valid number");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
