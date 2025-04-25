using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Even
    {
        int i;
        public void even()
        {
            Console.WriteLine("****** 1 to 100 Even Numbers *******");
            Console.WriteLine("Even Numbers");
            for(int i=0; i<=100; i++)
            {
                if(i %2 == 0)
                {
                    Console.WriteLine($" Even {i},");
                }
                                
            }
            Console.ReadKey();
        }
    }
}
