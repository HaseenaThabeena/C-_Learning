using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Factorial
    {
        int number;
        int j=1;
        public void get_input()
        {
            Console.WriteLine("Enter the factorial number");
            number = Convert.ToInt32(Console.ReadLine());
            fact();
        }
        public void fact()
        {
            for(int i=1; i<=number; i++)
            {
                j = j * i;
                Console.WriteLine(j);
            }
            //Console.WriteLine($"Factorial value {number} " + j);
            Console.ReadKey();
        }
    }
}
