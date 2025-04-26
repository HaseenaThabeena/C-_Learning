using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class EventCounter
    {
        public int CountEvenNumbers(int start, int end)
        {
            int count = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public void Run()
        {
            Console.Write("Enter start number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter end number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            int result = CountEvenNumbers(start, end);

            Console.WriteLine($"Number of even numbers between {start} and {end}: {result}");
            Console.ReadKey();
        }
    }
}
