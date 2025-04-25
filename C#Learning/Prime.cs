using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Prime
    {
        int a, b;
        public void getInput()
        {
            Console.WriteLine("****** Prime Numbers ******");
            Console.WriteLine("Enter the number to check prime or not");
            a = Convert.ToInt32(Console.ReadLine());
            primevalue();
        }
        public void primevalue()
        {
            for(int i =1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    b++;
                }
            }
            if(b >= 3)
            {
                Console.WriteLine($"{a} is not prime");
            }
            else
            {
                Console.WriteLine($"{a} a prime");
            }
            Console.ReadKey();
        }
    }
}
