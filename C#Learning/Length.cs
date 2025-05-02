using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Length
    {
        public void getInput()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            LengthOfLastWord(input);
        }
        public void LengthOfLastWord(string s)
        {
            string[] words = s.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int length = words[words.Length - 1].Length;
            Console.WriteLine($"Length of last word: {length}\n");
            Console.ReadKey();
        }
    }
}
