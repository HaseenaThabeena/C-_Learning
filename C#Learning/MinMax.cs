using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class MinMax
        {
        public void Min_Max()
        {
            int[] Array1 = { 1, 2, 5, 7, 3, 12, 4, 78, 4, 43, 56, 89, 21, 34 };
            Array.Sort(Array1);
            Console.WriteLine("Min " + Array1[0]);
            int a = Array1.Length;
            Console.WriteLine("Max " + Array1[a - 1]);
            Console.ReadKey();
        }   

    }
}
