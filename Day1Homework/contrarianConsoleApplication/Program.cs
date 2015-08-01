using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contrarianConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of objects defining what we want to identify in the user's string.
            char[] lookFor = { ' ' };
            string finalText = "";

            //Prompts the user to tell the computer something they do or don't like
            Console.WriteLine("Please use a complete sentence to tell me something you either like or don't like");
            //Identifies and stores the user's input in the variable userInput
            string userInput = Console.ReadLine();

            //creates an array and fills it with userInput.  creating a new index at every ' '
            string[] stringArray = userInput.Split(lookFor);
            
            
            for (var i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] == "don't")
                {
                    stringArray[i] = " like ";
                    stringArray[i+1] = "";
                    finalText += stringArray[i];
                }
                else if (stringArray[i] == "like" && stringArray[i-1] != "do")
                {
                    stringArray[i] = " don't like ";
                    finalText += stringArray[i];
                }
                /*else if (stringArray[i] == "like" && stringArray[i - 1] == "do")
                {
                    stringArray[i-1] = " not like ";
                    stringArray[i] = "";
                    stringArray[i + 1] = "";
                    //stringArray[i] = stringArray[i + 1];
                    finalText += stringArray[i];
                }*/
                else
                {
                    finalText += stringArray[i];
                }

            }
            Console.WriteLine(String.Join(" ", finalText));
            Console.ReadLine();
        }

        }
    }

