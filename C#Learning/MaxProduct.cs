using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class MaxProduct
    {
        public int [] n = { 3, 1, 6 , 8 };
        int a;
        public void Maxproduct()
        {
            for (int i = 0; i < n.Length; i++)
            {
                int temp;
                for (int j = 1; j < n.Length; j++)
                {

                    temp = n[i];
                    a = n[i] * n[j];
                    n[j] = temp;


                    if (a < temp)
                    {
                        Console.WriteLine(a);
                    }
                }
            }
            Console.ReadKey();
        }
     
    }
}
