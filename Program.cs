using System;
using System.Collections.Generic;
using Inheritance.Animals;


namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal> {
                new Tiger { Name = "Hobbes", FurLength = 15 },
                new Cat { Name = "Boots", FurLength = 12 },
                new Dog { Name = "Fido", FurLength = 8 },
                new Snake { Name = "Snek" }
            };

            foreach (Animal animal in animals)
            {
                animal.Speak();
            };

            animals[0].Sleep();
            Console.WriteLine($"{animals[0].Name} is {animals[0].SleepStatus}");

            foreach (Animal animal in animals)
            {
                if (animal is Mammal)
                {
                    Mammal mammal = (Mammal)animal;
                    mammal.GetAHaircut();
                    Console.WriteLine($"{mammal.Name} has a fur length of {mammal.FurLength}");
                }
            }
        }



    }
}