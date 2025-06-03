using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class SameKey
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        Dictionary<int, string> dic1 = new Dictionary<int, string>();
        Dictionary<int, string> dic2 = new Dictionary<int, string>();

        public void same1(int id, string name)
        {
            dic.Add(id, name);
        }
        public void same2(int id,string name)
        {
            dic1.Add(id, name);
        }
        //public void displaydict() 
        //{
        //    foreach(var dictvaule in dic)
        //    {
        //        Console.WriteLine($"ID: {dictvaule.Key}, Name: {dictvaule.Value}");
        //    }
        //    Console.ReadKey();
        //}
        
        public bool equal(bool areEqual)
        {
            if (dic.Count == dic1.Count)
            {
                foreach (var kvp in dic)
                {
                    if (!dic1.ContainsKey(kvp.Key) || dic1[kvp.Key] != kvp.Value)
                    {
                        areEqual = false;
                        return false;
                    }
                }
                return true;
            }
            else
            {
                areEqual = false;
                return false;
            }
        }
            public void GetUnmatchedValues()
            {
                foreach (var kvp in dic)
                {
                    if (dic1.ContainsKey(kvp.Key) && dic1[kvp.Key] != kvp.Value)
                    {
                        dic2.Add(kvp.Key, kvp.Value);
                    }
                }              
                foreach (var item in dic2)
                {
                    Console.WriteLine($"ID: {item.Key}, Values: {item.Value}");
                }
                Console.ReadKey();
            }    
    }
}
