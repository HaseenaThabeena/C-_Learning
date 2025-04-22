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
            int[] arr = { 1, 2, 5, 7, 3, 12, 4, 78, 4, 43, 56, 89, 21, 34 , 100 , 500 };
            //Array.Sort(Array1);
            //Console.WriteLine("Min " + arr[0]);
            //int a = arr.Length;
            //Console.WriteLine("Max " + arr[a - 1]);
            //Console.ReadKey();
            int S = arr[0];
            int L = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (L < arr[i])
                {
                   L = arr[i];                  
                }
                if (S > arr[i])
                {
                   S = arr[i];         
                }
            }
            Console.WriteLine("Smallest is {0}", S);
            Console.WriteLine("Largest is {0}", L);
            Console.ReadKey();
        }   

    }
}
