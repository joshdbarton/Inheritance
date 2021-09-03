using System;

namespace Inheritance.Animals
{
    public class Animal
    {
        public string Name { get; set; }
        protected bool _isSleeping { get; set; }

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

        public virtual void Speak()
        {
            Console.WriteLine("Vague animal grumblings");
        }

    }

}