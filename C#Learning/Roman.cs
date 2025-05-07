using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Roman
    {
        public int RomanToInt(string s)
        {
            int value = 0;
            Dictionary<string, int> dic = new Dictionary<string, int>() {
                { "I", 1 },
                { "V", 5 },
                { "X", 10 },
                { "L", 50 },
                { "C", 100 },
                { "D", 500 },
                { "M", 1000 },
                };
            for(int i = 0; i < dic.Count; i++)
            {
                //if(dic.ContainsKey()
                //{
                //    Console.WriteLine("IV");
                //}
                //else if (dic.ContainsValue(9))
                //{
                //    Console.WriteLine("IX");
                //}
            }

            return value;
         
        }

    }
}
