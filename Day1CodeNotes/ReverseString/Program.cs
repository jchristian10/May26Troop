using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a sentence...");
            string userInput = Console.ReadLine();
            string[] inputArray = userInput.Split(' ');
            Array.Reverse(inputArray);
            
            
        }
    }
}
