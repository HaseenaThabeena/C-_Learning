using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Manager: Employee
    {
       public Manager(string name, int id) : base(name,id){}   

        public void ConductMeeting()
        {
            Console.WriteLine($"{GetName()}is conducting a meeting.");
            Console.ReadLine();
        }
        public override void Work()
        {
            Console.WriteLine($"{GetName()} is managing the team.");
            Console.ReadLine();
        }

    }
}
