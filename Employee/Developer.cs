using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Developer : Employee
    {
        public Developer(string name, int id) : base(name, id) {}
        public override void Work()
        {
            Console.WriteLine($"{GetName()} is writing code.");
            Console.ReadLine();
        }
    }
}
