using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Constructor
    {
        public string name;
        public int j;
        public Constructor() // Parameter Less Constructor
        {
            Console.WriteLine("Constructor called");
            
        }
        public Constructor(string n, int i) // Constructor Overloading | Parameterized Constructor
        {
            this.name = n;
            this.j = i;
            Console.WriteLine(name + j);
        }
        public Constructor(Constructor cons1)
        {
            name = cons1.name;
            Console.WriteLine("Copy constructor" + name);
            Console.ReadKey();
        }
    }
}
