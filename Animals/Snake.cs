using System;

namespace Inheritance.Animals
{
    public class Snake
    {
        public string Name { get; set; }
        public int SkinAge { get; set; }
        private bool _isSleeping { get; set; }

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

        public void Hiss()
        {
            Console.WriteLine("hiss!");
        }

        public void HuntPrey(string prey)
        {
            Console.WriteLine($"{Name} ate a {prey}");
        }
    }

}