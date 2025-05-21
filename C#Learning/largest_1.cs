using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    //1. Find the Largest Number in an List 
    internal class largest_1
    {
        List<int> listvalue = new List<int> { 5, 8, 9, 10, 15 };
        public void largestvalue()
        {
            Console.WriteLine("Largetst value:" + listvalue.Max());
            Console.ReadKey();
        }
    }
}
