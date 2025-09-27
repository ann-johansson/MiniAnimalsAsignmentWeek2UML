using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AsignmentWeek2UML
{
    public class Dog : Animals // Derived class
    {
        // New attributes specific to Dog
        public string breed;
        public string owner;

        public void Bark() // New method specific to Dog
        {
            Console.WriteLine($"{name} barks!");
        }
        public override void MakeSound() // Override Animals abstract method
        {
            Console.WriteLine($"{name} says Voff!");
        }
        public override void WriteOutInfo() // Override Animals abstract method
        {
            Console.WriteLine($"{name} is a {age} years old {breed} {type}. {owner} is their owner.");
        }
    }
}
