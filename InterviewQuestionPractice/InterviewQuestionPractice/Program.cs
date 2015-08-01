using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestionPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            int divideBy = 2;
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for(var i = 0; i<intArray.Length; i+=1)
            {
                if(intArray.Value(i) % divideBy != 0)
                {
                    Console.WriteLine("The number {0} is an even number!", i);
                }
                //else
                //{
                //    Console.WriteLine("The number {0} is not an even number...", i);
                //}
            }

            Console.ReadKey();


        }
    }
}
