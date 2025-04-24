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
            Console.WriteLine("Reverse String: " );
            foreach (var item in revname)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
        
    }
}
