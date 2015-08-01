using AnimalInterface.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var bear = new Bear();
            bear.Name = "BooBoo";
            bear.Sound = "RAAWWRRR";

            var chicken = new Chicken();
            chicken.Name = "Clucky";
            chicken.Sound = "Cluck-Cluck-Cluck";

            var eagle = new Eagle();
            eagle.Name = "Murca";
            eagle.Sound = "CAAAWWW";

            var animalUtility = new AnimalUtility();

            animalUtility.DoSomething(eagle);
            Console.ReadLine();
        }
    }
}
