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
            int count = 0;
            int k = 0;
            for (int i = 0; i < Array1.Length; i++)
            {
             
                for (int j = 1; j < Array1.Length; j++)
                {

                     if (Array1[i] == Array1[j])
                    {
                        k = i;
                        count = count + 1;
                    }
                    
                }

                //Console.WriteLine("k" + k +"i" + i);
            }

            if (count > 1)
            {
                Console.WriteLine(Array1[k] + " Duplicates " + count);
            }

            Console.ReadKey();
        }
    }
}
