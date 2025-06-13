using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public  class Groupwords
    {
        List<string> names = new List<string>
        { "Arun", 
          "Anjali",
          "Vikram",
          "Vishnu",
          "Manoj",
          "Maya" 
        };
        public void grouping()
        {
          foreach(var item in names)
            {
                if (item.StartsWith("A"))
                {
                    Console.WriteLine("A:" + item);
                }
                if (item.StartsWith("M"))
                {
                    Console.WriteLine("M:" + item);
                }
                if (item.StartsWith("V"))
                {
                    Console.WriteLine("V:" + item);
                }
            }
            Console.ReadKey();
        }
        
    }
}
