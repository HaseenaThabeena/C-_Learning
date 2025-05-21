using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Numberguess
    {
        string  randomnum;
        Random r = new Random();
        int num;
        string num1;
        public void randaom_num()
        {
            num = r.Next(0000,9999);
            num1 = Convert.ToString(num);
            num1.Split(' ');
            Console.WriteLine(num1);
        }
        public void getInput()
        {
            randaom_num();
            Console.WriteLine("Enter 4 digit number");
            randomnum = Console.ReadLine();
            randomnum.Split(' ');
            numbergame();
        }
        public void numbergame()
        {
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] == randomnum[i])
                {
                    Console.Write("+");
                    //return;
                }
                else if (num1.Contains(randomnum[i]))
                {
                    Console.Write("-");                   
                }                                
                else
                {
                    Console.Write("*");                    
                }            
            }
            Console.ReadKey();
        }

    }
}
