using System;

namespace Inheritance.Animals
{
    public class Tiger
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

        public void Roar()
        {
            Console.WriteLine("ROAR!");
        }

        public void HuntPrey(string prey)
        {
            Console.WriteLine($"{Name} ate a {prey}");
        }
    }
}