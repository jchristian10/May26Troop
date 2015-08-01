using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Hw1PlayMovieQuotes
{
    class Program
    {
        static void Main(string[] args)
        {   
            SoundPlayer alrightyThen = new SoundPlayer(@"http://jimcarreyonline.com/soundclips/ace/aallrighty.wav");
            SoundPlayer lackOfFaith = new SoundPlayer(@"http://www.rosswalker.co.uk/star_wars_sounds/wavs/vader_faith.wav");
            SoundPlayer goInThere = new SoundPlayer(@"http://jimcarreyonline.com/soundclips/ace/donot.wav");
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    alrightyThen.Play();
                    break;
                case 2:
                    lackOfFaith.Play();
                    break;
                case 3:
                    Console.WriteLine("Testing Case 3");
                    goInThere.Play();
                    break;

                default:
                    Console.WriteLine("A soundbite could not be found, please try again.");
                    break;


            }
            Console.Read();

            /*
            var array = new string[] { "link", "link", "link" };
            Random rnd = new Random();
            int index = rnd.Next(3);
            
            try
            {
                SoundPlayer player = new SoundPlayer(array[index]);
                player.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepton Message")
            }
            */

        }
    }
}

