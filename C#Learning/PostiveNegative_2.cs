using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class PostiveNegative_2
    {
        //Count Positive and Negative Numbers
        List<int> listvalue = new List<int> { -5, -8, 9, 10, 15,-10,-5,4,6,-2 };
        int count = 0;
        public void countvalue()
        {
            for (int i = 0; i < listvalue.Count; i++)
            {
                if (listvalue[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Total Negative value" + count);
            Console.WriteLine("Total Positive Value" + (listvalue.Count - count));
            Console.ReadKey();
        }
    }
}
