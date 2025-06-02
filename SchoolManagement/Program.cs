using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students student = new Students();
            student.add_Profile(1, "John Doe");
            student.add_Profile(2, "Alice Smith");
            student.add_Profile(1, "John Doe");
            student.DisplayAllStudents();

            // Teaching Staff
            TeachingStaff teacher = new TeachingStaff();
            teacher.add_Profile(10, "Dr. Brown");
            teacher.add_Profile(11, "Prof. Green");
            teacher.add_Profile(10, "Dr. Brown");
            teacher.DisplayAllTeachingStaff();

            // Non-Teaching Staff
            NonTeachingStaff nonTeach = new NonTeachingStaff();
            nonTeach.add_Profile(20, "Mr. White");
            nonTeach.add_Profile(21, "Ms. Black");
            nonTeach.add_Profile(20, "Mr. White");
            nonTeach.DisplayAllNonTeachingStaff();
        }
    }
}
