using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Students : Management
    {
        Dictionary<int, string> Student = new Dictionary<int, string>();
        public override void add_Profile(int id, string name)
        {
            if (!Student.ContainsKey(id))
            {
                Student.Add(id, name);
                Console.WriteLine($"\n Student profile added: {id} - {name}");
            }
            else
            {
                Console.WriteLine($"\n Student ID {id} already exists.");
            }
        }
        public void DisplayAllStudents()
        {
            Console.WriteLine("\n --- All Student Profiles ---");
            foreach (var profile in Student)
            {
                Console.WriteLine($"ID: {profile.Key}, Name: {profile.Value}");
            }
            Console.ReadKey();
        }

    }
}
