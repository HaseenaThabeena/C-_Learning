using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Frequent
    {
        //  Dictionary<string, string> dict= new Dictionary<string, string>();
        List<string> list = new List<string>(7);
        char ch;
        public void input()
        {
            //Console.WriteLine("Enter the string to check the frequency");
            //dict = Console.ReadLine();
            //dict.Add("list0", "AA");
            //dict.Add("list1", "BB");
            //dict.Add("list2", "AA");
            //dict.Add("list3", "CC");
            //dict.Add("list4", "AA");
            //dict.Add("list5", "DD");
            list.Add("AAA");
            list.Add("BBB");
            list.Add("AAA");
            list.Add("CCC");
            list.Add("AAA");
            list.Add("DDD");
            list.Add("AAA");
            checkFrequency();
        }
        public void checkFrequency()
        {
            //foreach(KeyValuePair<string,string> dictonary in dict)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}",dictonary.Key,dictonary.Value);

            //}
            foreach (string item in list)
            {
                Console.WriteLine(item);
                //if (list[[item]])
            }
            

            Console.ReadKey();
           
        }
    }
}
