using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] headlines = new string[] { "Mars Attacks!", "Seahawks Win SuperBowl!", "Bears Best Team in NFL!" };
            Console.WriteLine(headlines.randomNumber());
            Console.ReadLine();
        }



    }

    public static class Program1
    {
        public static string randomNumber(this string[] numberName)
        {

            Random rnd = new Random();
            string newRandom = numberName[rnd.Next(0, numberName.Length)];
            return newRandom;
            //return randomNumber();
        }
    }
}
