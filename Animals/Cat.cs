using System;

namespace Inheritance.Animals
{
    public class Cat : Animal
    {
        public int FurLength { get; set; }
        public override void Speak()
        {
            Console.WriteLine("meow!");
        }

        public void WalkOnKeyboard()
        {
            Console.WriteLine("a;oiiwa;asd;;vfmcx opiewrn asdgpqe f");
        }
    }

}