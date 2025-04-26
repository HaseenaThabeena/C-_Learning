using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class SecLarge
    {
        int[] large = new int[10];
        public void getInput()
        {
            Console.WriteLine("****** Largest 3 Numbers ******");
            Console.WriteLine("Enter the 10 values");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                large[i] = Convert.ToInt32(Console.ReadLine());
            }
            output();
        }
        public void output()
        {
            Array.Sort(large);
            Console.WriteLine("Second Largest element" + large[large.Length-1]);
            //for (int i = 1; i < large.Length; i++)
            //{
            //    if (large[i] >= 10)
            //    {
            //        Console.WriteLine("element greater than 10: " + large[i]);
            //        Console.WriteLine("Index" + i);
            //        break;
            //    }
            //}
            Console.ReadKey();
        }
    }
}
