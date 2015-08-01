using System;
namespace AnimalInterface.Animals
{
    interface IAnimal
    {
        string GetSound();
        string Name { get; set; }
        string Sound { get; set; }
    }
}
