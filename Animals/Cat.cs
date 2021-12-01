using System;

namespace Inheritance.Animals
{
    public class Cat
    {
        public string Name { get; set; }
        public int FurLength { get; set; }
        private bool _isSleeping = false;

        public string SleepStatus
        {
            get
            {
                return _isSleeping ? "asleep" : "awake";
            }
        }

        public void Sleep()
        {
            _isSleeping = true;
        }

        public void Wakeup()
        {
            _isSleeping = false;
        }
        public void Meow()
        {
            Console.WriteLine("meow!");
        }

        public void WalkOnKeyboard()
        {
            Console.WriteLine("a;oiiwa;asd;;vfmcx opiewrn asdgpqe f");
        }
    }

}