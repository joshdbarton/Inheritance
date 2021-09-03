using System;

namespace Inheritance.Animals
{
    public class Snake : Animal
    {
        public int SkinAge { get; set; }
        public override void Speak()
        {
            Console.WriteLine("hiss!");
        }

        public void HuntPrey(string prey)
        {
            Console.WriteLine($"{Name} ate a {prey}");
        }
    }

}