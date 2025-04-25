using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Largest3
    {
        int[] large = new int[10];
        public void getInput()
        {
            Console.WriteLine("****** Largest 3 Numbers ******");
            Console.WriteLine("Enter the 10 values");

            for(int i=0; i <10; i++)
            {
                Console.Write("element - {0} : ", i);
                large[i] = Convert.ToInt32(Console.ReadLine());
            }
            output();
        }
        public void output()
        {
            Array.Sort(large);
            Console.WriteLine("Largest 3 numbers");
            int a = large.Length;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(large[a - i]);

            }
            Console.ReadKey();
        }

    }
}
