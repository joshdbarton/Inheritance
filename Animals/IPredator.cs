using System;

namespace Inheritance.Animals
{
    public interface IPredator
    {
        string Name { get; set; }
        void HuntPrey(string prey);
    }
}