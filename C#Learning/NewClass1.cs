using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    public struct student
    {
        public string Name ;
        int Age ;
        public student(string name, int age)
        {
            Name = name;
            Age = age;

        }
    }

    public class Students
    {
        public string Name="fgfg";
        public int Age =34;
        string Stu_Id="DES_03";
        public Students(string name, int age, string stuid)
        {
            Name = name;
            Age = age;
            Stu_Id = stuid;
        }
    }
    internal class NewClass1
    {
        Dictionary<int, student> dict = new Dictionary<int, student>();
        public void studentname()
        {
            dict[1] = new student("abc", 23);

            dict.Add(2, new student("abcde", 28));
        }

        Dictionary<int, Students> dict1 = new Dictionary<int, Students>();
        public void studentdetails()
        {
            dict1[1] = new Students("abc", 23, "DES_01");

            dict1.Add(2, new Students("abcde", 28, "DES_02"));

            Students stu = dict1[1];
            Console.WriteLine($"Name: {stu.Name}, Age:{stu.Age}");
        }

        Dictionary<int, string> d = new Dictionary<int, string>();
        public void onlydetails()
        {
            d.Add(1, "ssd");
            d.Add(2, "dfd");
            string s1 = d[2];
            Console.WriteLine($"id {s1}");

        }
    }
}
