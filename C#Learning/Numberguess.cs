using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Numberguess
    {
        int  random_num;
        Random r = new Random();
        int num;
        public void randaom_num()
        {
            num = r.Next(0000,9999);
            Console.WriteLine(num);

            Console.ReadKey();
        }
        public void getInput()
        {
            Console.WriteLine("Enter 4 digit number");
            random_num = Convert.ToInt32(Console.ReadLine());
        }
        public void numbergame()
        {
            for(int i=0; i < 4; i++)
            {
                //if (num == randaom_num)
                //{

                //}
            }
        }
    }
}
