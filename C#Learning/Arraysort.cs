using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Arraysort
    {
        int[] arr = { 5, 4, 1, 3, 9, 7 };
        int temp;
       
        public void sortarray()
        {
          
            for (int i=0; i<arr.Length; i++)
            {
               for (int j=0; j<arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {

                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
