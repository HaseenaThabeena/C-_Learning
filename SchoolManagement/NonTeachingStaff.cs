using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class NonTeachingStaff : Management
    {
        private Dictionary<int, string> nonTeachingProfiles = new Dictionary<int, string>();

        public override void add_Profile(int id, string name)
        {
            if (!nonTeachingProfiles.ContainsKey(id))
            {
                nonTeachingProfiles.Add(id, name);
                Console.WriteLine($"\n Non-Teaching staff profile added: {id} - {name}");
            }
            else
            {
                Console.WriteLine($"\n Non-Teaching Staff ID {id} already exists.");
            }
        }

        public void DisplayAllNonTeachingStaff()
        {
            Console.WriteLine("\n --- All Non-Teaching Staff Profiles ---");
            foreach (var profile in nonTeachingProfiles)
            {
                Console.WriteLine($"ID: {profile.Key}, Name: {profile.Value}");
            }
            Console.ReadKey();
        }

    }
}
