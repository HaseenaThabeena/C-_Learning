using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Stringalignement
    {
        string str = "coding4 love2 I1 Python3";
        public void value()
        {
            string[] words = str.Split(' ');
            Dictionary<int, string> dictvalue = new Dictionary<int, string>();
            foreach (var item in words)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (char.IsDigit(item[i]))
                    {
                        int position = item[i] - '0';
                        string cleanWord = item.Remove(i, 1);
                        dictvalue[position] = cleanWord;
                        break;
                    }
                }        
                string result = " ";
                for (int i = 1; i <= dictvalue.Count; i++)
                {
                    result += dictvalue[i];
                    if (i < dictvalue.Count)
                        result += " ";
                }
                Console.WriteLine(result);              
            }
            Console.ReadKey();
        }
    }
}