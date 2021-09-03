using System;

namespace Inheritance.Animals
{
    public class Dog : Mammal
    {
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