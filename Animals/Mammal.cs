using System;

namespace Inheritance.Animals
{
    public class Mammal : Animal
    {
        public int FurLength { get; set; }
        public void GetAHaircut()
        {
            FurLength--;
        }
    }
}