using System;

namespace Inheritance.Animals
{
    public class Dog
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

        public void Bark()
        {
            Console.WriteLine("woof!");
        }

        public string Fetch(string thing)
        {
            return thing;
        }
    }

}