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
            int total = 0;
            int prevValue = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>() 
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };
            foreach (char c in s)
            {
             int currentValue = dic[c];
                if (prevValue < currentValue)
                {
                   total += currentValue - 2 * prevValue;
                }
                else
                {
                   total += currentValue;
                }
                   prevValue = currentValue;              
            }
            
            return total;            
        }
    }
}
