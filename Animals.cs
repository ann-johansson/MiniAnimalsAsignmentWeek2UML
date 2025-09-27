using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AsignmentWeek2UML
{
    public abstract class Animals // Abstract base class
    {
        // Basic attributes for all animals
        public string name;
        public string type;
        public int age; 

        public void Eat() // Common method for all animals
        {
            Console.WriteLine($"{name} is eating.");
        }
        public void Sleep() // Common method for all animals 
        {
            Console.WriteLine($"{name} is sleeping.");
        }
        public abstract void MakeSound(); // Abstract method
        public abstract void WriteOutInfo(); // Abstract method

    }
}
