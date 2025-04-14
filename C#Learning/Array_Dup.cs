using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Array_Dup
    {
        public void arrayDuplicate()
        {

            int[] Array1 = { 1, 2, 5, 7, 3, 12, 4, 78, 4, 43, 56, 89, 21, 34 };

            for (int i = 0; i < Array1.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < Array1.Length; j++)
                {

                    if (Array1[i] == Array1[j])
                        count = count + 1;

                }

                if (count > 1)
                {
                    Console.WriteLine(Array1[i] + " Duplicates " + count);
                }
            }
            Console.ReadKey();
        }
    }
}
