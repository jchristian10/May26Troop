using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestPractice
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a string");
            string userInput = Console.ReadLine();
            Console.WriteLine(WordTools.ReverseWords(userInput));
            Console.ReadKey();

            Console.WriteLine("Please enter another string");
            string userInput2 = Console.ReadLine();
            Console.WriteLine(WordTools.ReverseChars(userInput2));
            Console.ReadKey();

            //Console.WriteLine(StringHelper.ReverseString(Console.ReadLine()));
            //Console.ReadKey();

        }
    }

   public static class WordTools
   {
       public static string ReverseWords(string s)
       {
           string[] words = s.Split(' ');
           Array.Reverse(words);
           return string.Join(" ", words);
       }

       public static string ReverseChars(string s)
       {
           char[] c = s.ToCharArray();
           Array.Reverse(c);
           return string.Join("", c);
       }
   }



    //public class StringHelper
    //{
    //    //Reverse a string.
    //    public static string ReverseString(string s)
    //    {
    //        char[] charArray = s.ToArray();
    //        Array.Reverse(charArray);
    //        return new string(charArray);
    //    }
    //}

}
