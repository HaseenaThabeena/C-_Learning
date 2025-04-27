using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Stringalignement
    {
        string str;
        Dictionary<int, string> dictvalue = new Dictionary<int, string>();
        public void getInput()
        {
            Console.WriteLine("Enter the string with end numbers");
            str = Console.ReadLine();
            value();
        }
        public void value()
        {
            string[] words = str.Split(' ');
            foreach (var item in words)
            {
                int position = 0;
                string onlyWord = "";
                for (int i = 0; i < item.Length; i++)
                {                 
                    if (char.IsDigit(item[i]))
                    {
                        position = item[i];
                    }
                    else
                    {
                        onlyWord += item[i];
                    }
                }
                if (position != 0)
                    dictvalue[position] = onlyWord;
            }


            List<int> keys_sorted = new List<int>(dictvalue.Keys);
            keys_sorted.Sort();
            Console.Write("The Final Output:");
            foreach (var k in keys_sorted)
            {
                Console.Write(dictvalue[k] + " ");
            }
            Console.ReadKey();
        }
    }
}