using System;

namespace Inheritance.Animals
{
    public class Tiger : Animal
    {
        public int FurLength { get; set; }
        public override void Speak()
        {
            Console.WriteLine("ROAR!");
            _isSleeping = false;
        }

        public void HuntPrey(string prey)
        {
            Console.WriteLine($"{Name} ate a {prey}");
        }
    }
}