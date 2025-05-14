using System;
using System.Collections.Generic;

namespace C_Learning
{
    internal class StudentGrade
    {
        public Dictionary<string, int> students = new Dictionary<string, int>();

        public void totalstudent()
        {
            Console.Write("Enter total number of students: ");
            int total = Convert.ToInt32(Console.ReadLine());
            AddRecords(total);
        }

        private void AddRecords(int total)
        {
            for (int i = 0; i < total; i++)
            {
                Console.Write("Enter name for student : ");
                string name = Console.ReadLine();

                Console.Write("Enter grade for  (0-100): ");
                int grade = Convert.ToInt32(Console.ReadLine());

                
                students[name] = grade;
            }

            AverageRecord();
        }

        private void AverageRecord()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No student records available.");
                return;
            }

            double average = 0;
            foreach (var student in students)
            {
                average += student.Value;
            }

            average /= students.Count;

            Console.WriteLine($"\nAverage Grade: {average}");
            Console.ReadKey();
        }
    }
}
