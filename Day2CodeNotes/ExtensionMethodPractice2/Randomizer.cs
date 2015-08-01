using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//in this example we are going to build our own 'generic'

namespace ExtensionMethodPractice2
{
    public static class Randomizer
    {
        public static T randomizeItem<T>(this T[] array)  //This sets 'T' to whatever type the inputed array is.  if you get a string array, T will be 'string'
        {
            Random rnd = new Random();
            int index = rnd.Next(array.Length);
            return array[index];
        }
    }
}
