using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Reversestring
    {
        string name;
        char[] revname;
        public void getInput()
        {
            Console.WriteLine("Enter the String");
            name = Console.ReadLine();
            revname = name.ToCharArray();
            reverse();
        }
        public void reverse() {            
            Array.Reverse(revname);       
            string revstr = new string(revname);
            Console.WriteLine("Reverse String: " + revstr);
            Console.ReadKey();
        }
        
    }
}
