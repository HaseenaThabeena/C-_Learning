using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class newClass
    {
        int a =23, a1=34,c1;
        float b = 2.3f;
        double c = 235.86;
        string d = "MES INDIA";
        char e = 'w';
        bool f = true;
        int[] array1 = { 1, 3, 4, 6, 8, 9 };
        string[] strarray = { "aaa", "bbb", "ccc", "ddd" };
        List<double> li = new List<double> {1233,3433,2345,7665 };
        int sum;
        List<int> arr_list = new List<int> { 234,564,216,68,98};
        List<string> str_list = new List<string> { "dhsf", "sdsf" };
        List<int> value = new List<int> { -2, -6, -5, 34, -54, 232, 56 };
        int pvalue;

        enum en { Add, sub, mul, div};

        public void typeconversion()
        {
            int aa = Convert.ToInt32(c);
            string dd = Convert.ToString(e);
            float bb = Convert.ToSingle(a);
            double cc = Convert.ToInt64(a);
            char ee = Convert.ToChar(d);
        }
       
        public void add()
        {
            int arrayadd = array1[0] + array1[1];
            string array_str = strarray[2] + strarray[3];
        }
        public void listadd()
        {
            for(int i=0; i < li.Count; i++)
            {
               sum += Convert.ToInt32(li[i]);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        public int Operators()
        {
            en ope = en.Add;
            switch (ope)
            {
                case en.Add:
                     c1 = a + a1;
                    break;
                case en.sub:
                     c1 = a - a1;
                    break;
                case en.mul:
                    c1 = a * a1;
                    break;
                case en.div:
                    c1 = a / a1;
                    break;
                default:
                    c1 = 0;
                    break;
            }
            return c1;
        }
        public void List_fun()
        {
            arr_list.Add(2);
            str_list.Add("yehd");
            arr_list.Find(x=>x.Equals(234));
            str_list.Find(x=>x.StartsWith("d"));
            bool val = arr_list.Contains(234);

            if (arr_list.Contains(234))
            {
                string value = "Available";
            }
            else
            {
                string value = "Not available";
            }
            if(val == true)
            {
                string value = "Available";
            }
            else
            {
                string value = "Not available";
            }
        }
        public int Predicate()
        {
            Console.WriteLine(arr_list.Find(x => x.Equals(254)));
            foreach (var item in value)
            {
                if (item >= 0)
                {
                    pvalue = item;
                    break;
                }               
            }
            return pvalue;
            
        }

        
    }
}
