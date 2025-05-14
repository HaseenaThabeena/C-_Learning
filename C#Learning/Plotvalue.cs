using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Plotvalue
    {
        public int length;
        public int breath;
        
        public int areavale(int l,int b)
        {
            length = l;
            breath = b;
            return l * b;
        }
    }
}
