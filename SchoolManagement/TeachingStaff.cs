using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class TeachingStaff : Management
    {
        private Dictionary<int, string> teachingProfiles = new Dictionary<int, string>();

        public override void add_Profile(int id, string name)
        {
            if (!teachingProfiles.ContainsKey(id))
            {
                teachingProfiles.Add(id, name);
                Console.WriteLine($"\n Teaching staff profile added: {id} - {name}");
            }
            else
            {
                Console.WriteLine($"\n Teaching Staff ID {id} already exists.");
            }
        }

        public void DisplayAllTeachingStaff()
        {
            Console.WriteLine("\n--- All Teaching Staff Profiles ---");
            foreach (var profile in teachingProfiles)
            {
                Console.WriteLine($"ID: {profile.Key}, Name: {profile.Value}");
            }
            Console.ReadKey();
        }
    }
}
