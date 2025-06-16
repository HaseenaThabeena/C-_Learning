using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assessment
{
    public class Triangle
    {
        int n = 5, num = 1;
        public void pattern()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i;  j++)
                {
                    Console.Write(" " + (num+i));
                    num--;
                }
                num++;
                Console.WriteLine(" ");
            }         
        }
    }
}

