using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Vowels
    {
        string str;
        char[] vow = { 'a', 'e', 'i', 'o', 'u' };
        char[] a;
        int v, c;
        public void getInput()
        {
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            a = str.ToCharArray();
            for(int i=0; i<= a.Length; i++)
            {
                
                    if (a[i] == vow[i])
                    {
                        v++;
                    }
                
                Console.WriteLine($"Vowels {v}");
            }
            Console.ReadKey();
        }
    }
}
