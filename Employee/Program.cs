using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee("AAAA", 0001);
            Manager manager = new Manager("BBBB", 0002);
            Developer developer = new Developer("CCCCC", 0003);
            em.Work();
            manager.Work();
            developer.Work();
            manager.ConductMeeting();
        }
    }
}