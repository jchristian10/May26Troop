using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SmtpClient_Practice
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
            SmtpClient client = new SmtpClient();
            Console.

            MailMessage message = new MailMessage();
           
            Console.WriteLine("Enter a number");
            int input = Console.Read();
            int twice = input * 2;
            Console.WriteLine("You entered " + input +  ".  The double of your number is "+ twice );
            Console.ReadKey();
             * 
            string currentTime = DateTime.Now.ToShortTimeString();
            Console.WriteLine("The Current Time is " + currentTime );
            Console.Read();

            bool isTodayTuesday = true;
            int number = 1;
            long biggerNumber = 64bitInterger;
            float f l= 3.342;
            double db = 32.34;
            decimal dec = 234.234;
            

            MailMessage message = new MailMessage();
            message.Subject = "starting subject";
            Console.WriteLine(message.Subject);
            Console.ReadLine();
            ChangeSubject(MailMessage.Subject);
            Console.WriteLine(message.Subject);
            Console.ReadLine();
        }

        public static void ChangeSubject(MailMessage message)
        {
            message.Subject = "This is the new subject";
        }
        */

            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();

            int num = 0;

            if (int.TryParse(input, out num))
            {
                int doubleNumber = num + num;
                Console.WriteLine(doubleNumber);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry, your entry was not a nunmber!");
                Console.ReadLine();
            }

        }
    }
}
