using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Groups_Word
    {
        List<string> words= new List<string> {
    "Apple", "Ant", "Bat", "Ball", "banana", "Zebra", "Zoo",
    "apricot", "blue", "cat", "Cobra", "Camel", "apple", "Zoo"
        };
       
        public void grp_words()
        {
            Dictionary<char, List<string>> dict = new Dictionary<char, List<string>>();
            
            foreach (var item in words)
            {   
                string result = item.ToLower();
                char first = result[0]; // First character access from String
                if (!dict.ContainsKey(first))// Dict key present or not
                {
                    dict.Add(first, new List<string> { result });
                }
                else
                {
                    List<string> li = dict[first]; // get Value from the Dictionary
                    li.Add(result);
                    dict[first] = li;// Value reassign to the Dictionary                    
                }
            }
        }
    }
}
