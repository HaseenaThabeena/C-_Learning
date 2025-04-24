using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Table7
    {
        int number1,number ;
        public void getInput()
        {
            Console.WriteLine("Enter the value of the table");
            number = Convert.ToInt32(Console.ReadLine());
            multiply();
        }
        public void multiply()
        {
            for(int i = 1; i <= 10; i++)
            {
                number1 = number * i;
                Console.WriteLine($"{number} x {i}= {number1}");
               
            }
            Console.ReadKey();
        }
    }
}
