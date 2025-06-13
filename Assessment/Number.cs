using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Number
    {
        Dictionary<string, int> scores = new Dictionary<string, int>
        {
            {"Arun", 78},
            {"Kavya", 92},
            {"Vimal", 92},
            {"Sneha", 85}
        };
        int a;
        public void highscore()
        {
            a = scores.Values.Max();
       //     if (scores.Values < a)
            {

            }
        }
    }
}
