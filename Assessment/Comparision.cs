using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Comparision
    {
         Dictionary<string, int> scores = new Dictionary<string, int>
         {
            {"Arun", 78},
            {"Kavya", 92},
            {"Vimal", 92},
            {"Sneha", 85}
         };
        int a;
        public void compa()
        {
            a = scores.Values.Max();
            Console.WriteLine("Highest Score" + a);
            Console.WriteLine("Top Scorers:");
            foreach (var item in scores)
            {
                if(a== item.Value)
                Console.WriteLine(item.Key);
            }   
        }
    }
}
