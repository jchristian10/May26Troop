using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //adding methods to the program at runtime rather than at compile time
            //we define methods within classes


            //This is the example using the reverse extension method!
            
            string message = "Everything is Awesome!";
            Console.WriteLine(message);

            string revMessage = message.ReverseExtensionMethod();
            Console.WriteLine(revMessage);  //This will output the message reversed
            Console.ReadLine();



            //This is the example using the static reverse method.
            string message2 = "Everything is also awesome!";
            Console.WriteLine(message2);

            string revMessage2 = StringUtility.Reverse(message2);
            Console.WriteLine(revMessage2);  //This will output the message reversed
            Console.ReadLine();
            

            string message3 = "Surprisingly, everything is still awesome!";
            string revMessage3 = message3.ReverseExtensionMethod();
            revMessage3.WriteColor(ConsoleColor.DarkGray, ConsoleColor.Blue);
            Console.WriteLine(message3);
            Console.ReadLine();


        }

    }

    public class StringUtility
    {
        public static string Reverse(string text)   //this method will take a string input and reverse it.
        {
            var textArray = text.ToCharArray(); //turns the inputed string 'text' into a character array 'textArray'
            Array.Reverse(textArray);  //calls the Reverse method on the array 'textArray'
            return new String(textArray);  //returns the array as a string type.  the String() class can take an inputted value and turn it into a string
        }
    }

    public static class StringExtensions  //AS SOON AS YOU MAKE A CLASS STATIC ALL METHODS INSIDE MUST BE STATIC!!!!
    {
        public static string ReverseExtensionMethod(this string stringToExtend)  //This is the creation of an extension method.  all that is required to call the method (as seen above) is .Reverse  DO NOT FORGET TO USE 'This'
        {
            var textArray = stringToExtend.ToCharArray(); 
            Array.Reverse(textArray);  
            return new String(textArray);  
        }

        public static void WriteColor(this string stringToExtend, ConsoleColor backgroundColor, ConsoleColor foregroundColor)  //An extension method with parameters.  those parameters are backgroundColor and foregroundColor
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(stringToExtend);
        }
    }
}
