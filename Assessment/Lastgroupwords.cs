using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Lastgroupwords
    {
    //    List<string> words = new List<string> {
    //"Apple", "Ant", "Bat", "Ball", "banana", "Zebra", "Zoo",
    //"apricot", "blue", "cat", "Cobra", "Camel", "apple", "Zoo"
    //    };
    //    public void grup_lastword()
    //    {
    //        Dictionary<char, List<string>> dict = new Dictionary<char, List<string>>();
    //       foreach(var item in words)
    //       {
    //            char result = item.Last();
    //            if (!dict.ContainsKey(result))
    //            {
    //                dict.Add(result, new List<string> { item});
    //            }
    //            else
    //            {
    //                List<string> li = dict[result];
    //                li.Add(item);
    //                dict[result] = li;
    //            }
    //       }
    //    }
    //    public void forgrplastword()
    //    {
    //        Dictionary<char, List<string>> dict = new Dictionary<char, List<string>> { };
    //        for(int i=0; i < words.Count; i++)
    //        {
    //            string a = words[i];
    //            char last = a.Last();
    //            if (!dict.ContainsKey(last))
    //            {
    //                dict.Add(last, new List<string> { words[i] });
    //            }
    //            else
    //            {
    //                List<string> li = dict[last];
    //                li.Add(words[i]);
    //                dict[last] = li;
    //            }
    //        }
    //    }

    //    public int [] sortedarray(int[] nums)
    //    {
    //       for(int i = 0; i < nums.Length; i++)
    //        {
    //            int a = nums[i] * nums[i];
    //            nums[i] = a;
    //        }
    //        Array.Sort(nums);
    //        return nums;
    //    }
    //    public string ToLowercase(string s)
    //    {
    //        string a = s.ToLower();
    //        return a;
    //    }
        public bool rotatestring(string s, string goal)
        {
            bool T =false; // Majority only assign always
            string value_s = s;
            for(int i=0; i < s.Length; i++)
            {
                char str = s[0];
                int start_index = s.Length - 1;
                s = s.Remove(0,1);// Remove 0th postion and 1 character
                s = s.Insert(start_index, str.ToString()); // Insert 4,0th character
              //  s = s.Substring(1, s.Length - 1) + s.Substring(0, 1); // Instead of Remove we can use sub string
                if (s== goal)
                {
                    T = true;
                    break;
                }

            }

            return T;
        }



}
}
