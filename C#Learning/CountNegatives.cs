using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class CountNegatives
    {
        int[] numbers = new int[10];
        int count = 0;
        public void getInput() { 
             Console.WriteLine("****** Count negative Numbers ******");
            Console.WriteLine("Enter the 10 values");

            for(int i=0; i<10; i++)
            {
                Console.Write("element - {0} : ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            CountNegativeNumbers();
    }
        public void CountNegativeNumbers()
        {
            foreach (int num in numbers)
            {
                if (num < 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Total negative numbers: " + count);
            Console.ReadKey();
        }
    }
}
