using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessment
{
    public class Alphabets
    {
        List<string> names = new List<string> { "Nagaraj", "Haseena", "Anand", "Ahameed" };
        public void repeat()
        {
            foreach (string name in names)
            {
                string result = " ";
                string lowerName = name.ToLower();

                for (int i = 0; i < lowerName.Length; i++)
                {
                    if (result.Contains(lowerName[i]) == false)
                    {
                        result += lowerName[i];
                    }
                }

                Console.WriteLine(result);

            }
            Console.ReadKey();
        }
    }
}
