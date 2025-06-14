using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Employee
    {
        private string name;
        private int id;
      
        public Employee(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public string GetName()
        {
            return name;
        }
        public int GetID()
        {
            return id;
        }
        public virtual void Work()
        {
            Console.WriteLine($"{name} is doing general office work." );
            Console.ReadLine();
        }
    }
}
