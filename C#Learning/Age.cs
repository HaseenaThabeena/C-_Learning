using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Age
    {
        int age;
        bool isValid;
        public void getInput()
        {
            Console.Write("Enter your age: ");
           // age = Convert.ToInt32(Console.ReadLine());
             isValid = int.TryParse(Console.ReadLine(), out age);
            checkage();
        }
        public void checkage()
        {
            if(!isValid || age < 0){
                Console.WriteLine("Invalid Age");
            }
            else if (age >= 0 && age <= 12)
            {
                Console.WriteLine("You are a child.");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if (age >= 20 && age <= 64)
            {
                Console.WriteLine("You are an adult.");
            }
            else 
            {
                Console.WriteLine("You are a senior.");
            }
            Console.ReadKey();
        }
    }
}

