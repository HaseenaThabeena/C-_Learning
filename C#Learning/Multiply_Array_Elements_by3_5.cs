using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Multiply_Array_Elements_by3_5
    {
        List<int> li = new List<int> { 2, 4, 6, 7, 8, 9 };
        int val;
        
        public void multiply()
        {
            for (int i=0;i<li.Count; i++)
            {
                li[i] *= 3;
            }
            Console.WriteLine("Updated List:");
            foreach (int number in li)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
