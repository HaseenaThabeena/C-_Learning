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
        public Constructor()
        {
            Console.WriteLine("Constructor called");
            Console.ReadKey();
        }
        public Constructor(string n, int i)
        {
            this.name = n;
            this.j = i;
            Console.ReadKey();
        }
    }
}
