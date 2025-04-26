using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Divisors
    {
        int number;
        public void getInput()
        {
            Console.WriteLine("Enter the value");
            number = Convert.ToInt32(Console.ReadLine());
            FindDivisors();
        }

        public void FindDivisors()
        {
            Console.WriteLine("Divisors of " + number + ":");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
