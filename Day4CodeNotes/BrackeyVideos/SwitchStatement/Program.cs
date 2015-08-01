using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 100; i++)
            {
                switch(i % 2)
                {
                    case 0:
                        Console.WriteLine(i);
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
