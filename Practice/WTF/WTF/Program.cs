using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTF
{
    class Program
    {
        Program()
        {
            Console.WriteLine(TryCatchWhatTheFuck());
        }

        public string TryCatchWhatTheFuck()
        {
            try
            {
                //throw new Exception("exception");
                return "hello, world!";
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
    }
}
