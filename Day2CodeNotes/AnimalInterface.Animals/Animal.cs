using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface.Animals
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public string GetSound()
        {
            return this.Sound;
        }
    }
}
