using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
   
        // 59. Student grade management
        public class Student
        {
            public string Name;
            public List<int> Grades;

            public Student(string name)
            {
                Name = name;
                Grades = new List<int>();
            }

            public double GetAverage()
            {
                if (Grades.Count == 0) return 0;
                int sum = 0;
                foreach (int grade in Grades)
                    sum += grade;
                return (double)sum / Grades.Count;
            }
        }

        public class StudentManager
        {
            private List<Student> students = new List<Student>();

            public void AddStudent(string name, List<int> grades)
            {
                Student s = new Student(name);
                s.Grades.AddRange(grades);
                students.Add(s);
            }

            public void ShowAverageGrades()
            {
                foreach (var s in students)
                {
                    Console.WriteLine($"{s.Name}: Average = {s.GetAverage():0.00}");
                }
            }

            public void ShowTopStudents()
            {
                double maxAvg = 0;
                foreach (var s in students)
                {
                    double avg = s.GetAverage();
                    if (avg > maxAvg)
                        maxAvg = avg;
                }

                Console.WriteLine("Top Student(s):");
                foreach (var s in students)
                {
                    if (Math.Abs(s.GetAverage() - maxAvg) < 0.01)
                        Console.WriteLine($"{s.Name} with {maxAvg:0.00}");
                }
            }
        }
}
