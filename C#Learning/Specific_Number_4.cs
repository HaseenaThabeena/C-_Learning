using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    //Check If Array Contains a Specific Number
    internal class Specific_Number_4
    {
        List<int> listvalue = new List<int> { 2, 4, 19, 130, 135, 58 };
        int number,fin_count,no_count;
        public void input()
        {
            Console.WriteLine("Ask input number:");
            number = Convert.ToInt32(Console.ReadLine());
            findnumber();
        }
        public void findnumber()
        {
            for (int i = 0; i < listvalue.Count; i++)
            {
                if (listvalue[i] == number)
                {
                    fin_count++;
                    //Console.WriteLine("Found");
                    //return;
                }
                else
                {
                    no_count++;
                    //Console.WriteLine("Not Found");
                    //return;
                }           
            }
            Console.WriteLine(fin_count != 0 ? "Found" : "Not Found");
            Console.ReadKey();
        }

    }
}
