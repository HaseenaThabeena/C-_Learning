using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Class1
    {
        public void arrayfunc()
        {
            List<int> lis = new List<int>() { 1, 2, 3 };

            lis.Add(4);
            lis.Add(5);
            lis.Add(6);
            lis.Add(7);
            lis.Add(8);
            List<int> listrange = new List<int>() { 9,10,11,12 };
            //Console.WriteLine("********* List(ADD) *********");
            //for (int i = 0; i < lis.Count; i++)
            //{
            //    Console.WriteLine(lis[i]);
            //}
            //lis.Remove(2);
            //Console.WriteLine("********* List(Remove) *********");
            //for (int i = 0; i < lis.Count; i++)
            //{
            //    Console.WriteLine(lis[i]);
            //}
            //lis.RemoveAt(2);
            //Console.WriteLine("********* List(Remove index) *********");
            //for (int i = 0; i < lis.Count; i++)
            //{
            //    Console.WriteLine(lis[i]);
            //}
            lis.AddRange(listrange);
            Console.WriteLine("********* List(Add Range) *********");

            foreach (int num in lis)
            {
                Console.WriteLine(num);
            }

            //lis.Contains(1);
            //Console.WriteLine("********* List(Contains) *********");


            Console.ReadKey();
        }
        
    }
}
