using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Palindrome
    {   
        string str;
        char[] arr;   
        public void getInput()
        {
            Console.WriteLine("Enter the Word to check the Palindrome");
            str = Console.ReadLine();
            arr = str.ToCharArray();
            Array.Reverse(arr);
            string revstr = new string(arr);
            Console.WriteLine("arr: " + revstr);
           
            if(str == revstr)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

           
        }

    }
}
