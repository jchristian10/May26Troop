using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    class Program
    {
         static void Main(string[] args)
        {
            //var p1 = new Character();
            GameManager newGame = new GameManager();
            newGame.Play();
        }
    }
}
