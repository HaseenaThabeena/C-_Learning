using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Person
    {
        string name;
        int Age;
        public void getInfo()
        {
            Console.WriteLine("Enter the Person details");
            name = Console.ReadLine();
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Person name :{0} ", name);

        }
    }
}
