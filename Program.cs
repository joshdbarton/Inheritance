using System;
using Inheritance.Animals;
using System.Collections.Generic;

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

            foreach (Animal a in animals)
            {
                Console.Write($"{a.Name} says ");
                a.Speak();
            }

            Tiger tigger = new Tiger { Name = "tigger", FurLength = 18 };
            tigger.Sleep();
            Console.WriteLine($"{tigger.Name} is {tigger.SleepStatus}");

            Console.WriteLine(tigger);
            tigger.Haircut();
            Console.WriteLine($"{tigger.Name}'s fur length: {tigger.FurLength}");

            foreach (Animal a in animals)
            {
                if (a is IPredator)
                {
                    (a as IPredator).HuntPrey("rabbit");
                }
            }

            (animals[1] as Cat).WalkOnKeyboard();

            Cat boots = new Cat { Name = "Boots", FurLength = 20 };
            boots.WalkOnKeyboard();
            animals.Add(boots);
            (animals[4] as Cat).WalkOnKeyboard();
        }



    }
}