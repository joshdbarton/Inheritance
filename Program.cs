using System;
using Inheritance.Animals;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger hobbes = new Tiger { Name = "Hobbes", FurLength = 15 };
            Cat boots = new Cat { Name = "Boots", FurLength = 12 };
            Dog fido = new Dog { Name = "Fido", FurLength = 8 };
            Snake snek = new Snake { Name = "Snek" };

            Console.Write($"{hobbes.Name} says ");
            hobbes.Roar();
            Console.Write($"{boots.Name} says ");
            boots.Meow();
            Console.Write($"{fido.Name} says ");
            fido.Bark();
            Console.Write($"{snek.Name} says ");
            snek.Hiss();
        }



    }
}