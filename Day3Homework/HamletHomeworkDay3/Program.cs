using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HamletHomeworkDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            string HamletFile = Regex.Replace(File.ReadAllText("Hamlet.txt").Replace("\r\n", " "), @"[^\w\s]", ""); //gets rid of puncuation
            List<string> ignoreList = new List<string> {
                "the",
                "and",
                "to",
                "I",
                "my",
                "you",
                "not",
                "of",
                "a",
                "but",
                "for",
                "me"
            };

            var result = HamletFile
                .Split(' ')
                .Where(t => !string.IsNullOrWhiteSpace(t) && !ignoreList.Any(i => t.IndexOf(i, 0, StringComparison.CurrentCultureIgnoreCase) != -1)) //gets rid of extra spaces
                .GroupBy(t=>t, StringComparer.InvariantCultureIgnoreCase)
                .OrderByDescending(t => t.Count()).FirstOrDefault();

            //foreach()
            Console.WriteLine("The most used, not boring word was \"{0}\", and it was used {1} times", result.Key, result.Count());
            Console.ReadLine();
        }
    }
}
