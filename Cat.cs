using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignmentWeek2UML
{
    public class Cat : Animals // Derived class
    {
        public string furPattern; // New attribute specific to Cat

        public void Purr() // New method specific to Cat
        {
            Console.WriteLine($"{name} purrrrrs!");
        }
        public override void MakeSound() // Override Animals abstract method
        {
            Console.WriteLine($"{name} says Meow!");
        }
        public override void WriteOutInfo() // Override Animals abstract method
        {
            Console.WriteLine($"{name} is a {age} years old {type} with {furPattern} fur.");
        }
    }
}
