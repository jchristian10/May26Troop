using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    public class GameManager
    {   
       
        public DateTime GameStartTime { get; set; }
        List<Question> _questions;
        public void Play()  //method
        {
            Console.WriteLine("This gaame was started at {0}", DateTime.Now);
            Console.WriteLine("What is the Name of your character?");
            string p1Name = Console.ReadLine();
            Console.WriteLine("Welcome, {0}, Are you a Human, Orc, or Elf?", p1Name);
            string p1Race = Console.ReadLine();
            Console.WriteLine("Finally, {0} the {1}, are you a Warrior, Wizard, or Bard?", p1Name, p1Race);
            string p1Class = Console.ReadLine();
            Character P1 = new Character()  //creates a new character object
            {
                CharacterName = p1Name,
                CharacterRace = p1Race,
                CharacterClass = p1Class
            };

            Console.WriteLine("Welcome, {0}!  You must be the great {1} {2}, of which many songs have been sung!", P1.CharacterName, P1.CharacterRace, P1.CharacterClass);
            Console.ReadLine();

            Console.WriteLine("Before we get started, let me ask you a question...");

        }

        public GameManager() //This is the constructor and this is created automatically by the IDE.  By manually creating a constructor you can determin anything that happens when an object is instanciated
        {

        }
    }
}
