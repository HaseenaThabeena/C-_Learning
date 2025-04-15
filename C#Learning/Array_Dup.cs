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

            int[] Array1 = { 1, 2, 2,4,2 };
            for (int i = 0; i < Array1.Length; i++)
            {
                int count = 0;
                if (Array1[i] == -1)
                {
                    continue;
                }
                for (int j = 0; j < Array1.Length; j++)
                {

                    if (Array1[i] == Array1[j])
                    {
                        count = count + 1;
                        if (count > 1)
                        {
                            Array1[j] = -1;
                        }
                    }

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
