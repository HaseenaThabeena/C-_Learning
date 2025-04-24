using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Table7
    {
        int number1,number = 7;
        public void multiply()
        {
            for(int i = 1; i <= 10; i++)
            {
                number1 = number * i;
                Console.WriteLine($"7 x {i}= {number1}");
               
            }
            Console.ReadKey();
        }
    }
}
