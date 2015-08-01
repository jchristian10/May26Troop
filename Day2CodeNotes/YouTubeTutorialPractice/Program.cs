using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day3PracticeAndNotes
{
    class Program
    {
        class Person
        {
            public string Name;
            public int Height;
            public float Weight;
            public string CountryOfBirth;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Big Bang for our program just happened at {0}", DateTime.Now);
            Thread.Sleep(1000);
            Person p1 = new Person();
            p1.Name = "Josh";
            p1.Height = 80;
            p1.Weight = 224.5F;
            p1.CountryOfBirth = "United States";
            Console.WriteLine("Person created.  Name: {0}, Height: {1}, Weight: {2}, Country Of Birth: {3}", p1.Name, p1.Height, p1.Weight, p1.CountryOfBirth);

            Person p2 = new Person();
            p2.Name = "Brian";
            p2.Height = 66;
            p2.Weight = 173.4F;
            p2.CountryOfBirth = "United States";
            Console.WriteLine("Person created.");
            Console.WriteLine("The big colapse is just about to start at {0}", DateTime.Now);

            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();

        }

    }
}
//Video Link is https://www.youtube.com/watch?v=jnPVL9tBheA