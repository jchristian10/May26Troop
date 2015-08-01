using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface.Animals
{
    public class AnimalUtility
    {
        public void DoSomething(Animal newAnimal)
        {
            Console.WriteLine(newAnimal.Name + ", " + newAnimal.GetSound());
        }
    }
}
