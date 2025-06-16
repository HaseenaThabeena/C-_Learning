using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Lastgroupwords
    {
        List<string> words = new List<string> {
    "Apple", "Ant", "Bat", "Ball", "banana", "Zebra", "Zoo",
    "apricot", "blue", "cat", "Cobra", "Camel", "apple", "Zoo"
        };
        public void grup_lastword()
        {
            Dictionary<char, List<string>> dict = new Dictionary<char, List<string>>();
           foreach(var item in words)
           {
                char result = item.Last();
                if (!dict.ContainsKey(result))
                {
                    dict.Add(result, new List<string> { item});
                }
                else
                {
                    List<string> li = dict[result];
                    li.Add(item);
                    dict[result] = li;
                }
           }
        }
        public void forgrplastword()
        {
            Dictionary<char, List<string>> dict = new Dictionary<char, List<string>> { };
            for(int i=0; i < words.Count; i++)
            {
                string a = words[i];
                char last = a.Last();
                if (!dict.ContainsKey(last))
                {
                    dict.Add(last, new List<string> { words[i] });
                }
                else
                {
                    List<string> li = dict[last];
                    li.Add(words[i]);
                    dict[last] = li;
                }
            }
        }

        public int [] sortedarray(int[] nums)
        {
           for(int i = 0; i < nums.Length; i++)
            {
                int a = nums[i] * nums[i];
                nums[i] = a;
            }
            Array.Sort(nums);
            return nums;
        }
        public string ToLowercase(string s)
        {
            string a = s.ToLower();
            return a;
        }


}
}
