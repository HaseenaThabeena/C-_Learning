using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class StudentGrade
    {
        public int total,grade;
        public string name;
        //class Students
        //{
        //    public string name;
        //    public int grade;

        //}
        Dictionary<string,int> students = new Dictionary<string, int>();

        public void totalstudent()
        {
            Console.WriteLine("Total no. of student");
             total= Convert.ToInt32(Console.ReadLine());
            addrecords();
        }
        
        public void addrecords()
        {
            for (int i = 0; i <total; i++)
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();
                Console.Write("Enter student grade (0-100): ");
                int grade = Convert.ToInt32(Console.ReadLine());
            }
            averagerecord();
        }
        public void averagerecord()
        {
            int avgrecord;
            avgrecord = grade / total;
            Console.Write(avgrecord);
            Console.ReadKey();
        }

    }
}
