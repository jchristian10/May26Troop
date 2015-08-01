using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            List<int> intList = new List<int>();


            //string[] stringArray = new string[] { "Josh", "Cookie", "Table" };

            //ArrayList stringList = new ArrayList();

            stringList.Add("Josh");
            intList.Add(22);
            stringList.Add("Cookies");
            stringList.Remove("Josh");

            var stringArray = stringList.ToArray();

            List<string> newStringList = stringArray.ToList();



            foreach (var num in intList)
            {
                Console.WriteLine(num);
            }

            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }
            

            //Generic Dictionary 

            Dictionary<string, string> states = new Dictionary<string, string>();
            states.Add("TX", "Texas");
            states.Add("IL", "Illinois");
            states.Add("NY", "New York");

            Dictionary<int, string> months  = new Dictionary<int, string>();
            months.Add(1, "January");
            months.Add(2, "Feburary");

            string september;
            months.TryGetValue(9, out september);

            Console.ReadLine();
        }
    }
}
