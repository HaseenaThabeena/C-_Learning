using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class ReversePattern
    {
        int n = 5, num = 1;
        public void pattern()
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" " + num);
                    num++;
                }
                Console.WriteLine(" ");
            }
        }
    }
}
