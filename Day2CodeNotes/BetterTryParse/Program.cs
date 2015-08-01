using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "89";

            int parsedNumber;

            int.TryParse(number, out parsedNumber);

            var i = TryParseAsInt("I am not a number");  // using/calling/invoking the method

            Console.WriteLine(i);
            Console.ReadLine();

            
        }

        public static int? TryParseAsInt(string triedString)  //defining the method
        {
            int parsedData;
            if (int.TryParse(triedString, out parsedData))
            {
                return parsedData;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// same way to solve the problem above
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int? TryParseAsInt(string value)
        {
            try
            {
                return int.Parse(value);
            }
            catch
            {

            }

            return null;
        }
    }

}
