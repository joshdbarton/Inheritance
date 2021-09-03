using System;

namespace Inheritance.Animals
{
    public class Tiger : Mammal, IPredator
    {
        public override void Speak()
        {
            Console.WriteLine("ROAR!");
        }

        public void HuntPrey(string prey)
        {
            Console.WriteLine($"{Name} ate a {prey}");
        }
    }
}