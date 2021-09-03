using System;

namespace Inheritance.Animals
{
    public class Dog : Animal
    {
        public int FurLength { get; set; }

        public override void Speak()
        {
            Console.WriteLine("woof!");
        }

        public string Fetch(string thing)
        {
            return thing;
        }
    }

}