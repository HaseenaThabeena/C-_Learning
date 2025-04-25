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
        char[] vow = { 'a', 'e', 'i', 'o', 'u', 'A','E','I', 'O', 'U'};
        char[] a;
        int v, c;
        public void getInput()
        {
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            a = str.ToCharArray();
            for(int i=0; i< a.Length; i++)
            {
                for (int j = 0; j < vow.Length; j++)
                {
                    if (vow[j] == a[i])
                    {
                        v++;
                    }
                }                              
            }
            Console.WriteLine($"Vowels {v}");
            Console.WriteLine($"Constants {(a.Length) - v}");
            Console.ReadKey();
        }
    }
}
