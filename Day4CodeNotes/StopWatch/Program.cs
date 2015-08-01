﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StopWatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i <1000; i++)
            {
                numbers.Add(rnd.Next(1000));
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach(int number1 in numbers)
            {
                int duplicateCount = 0;
                foreach(int number2 in numbers)
                {
                    if(number1 == number2)
                    {
                        duplicateCount++;
                    }
                }

                Console.WriteLine("{0} has {1} duplicates!", number1, duplicateCount);
            }
            stopwatch.Stop();
            Console.WriteLine("Total time is {0} miliseconds.", stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
