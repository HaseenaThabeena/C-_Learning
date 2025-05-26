using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    //1. Find the Largest Number in an List 
    public class largest_1
    {
        List<int> listvalue = new List<int> { 5, 8, 9, 10, 15 };
        public void largestvalue()
        {
            Console.WriteLine("Largetst value:" + listvalue.Max());
            Console.ReadKey();
        }
    }
}
    public class PostiveNegative_2
    {
        //Count Positive and Negative Numbers
        List<int> listvalue = new List<int> { -5, -8, 9, 10, 15, -10, -5, 4, 6, -2 };
        int count = 0;
        public void countvalue()
        {
            for (int i = 0; i < listvalue.Count; i++)
            {
                if (listvalue[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Total Negative value" + count);
            Console.WriteLine("Total Positive Value" + (listvalue.Count - count));
            Console.ReadKey();
        }
    }

public class Sum_even_odd_3
{
    //Sum of Even and Odd Numbers
    List<int> listvalue = new List<int> { 2, 4, 19, 130, 135, 50, 51, 47, 68, 28 };
    int even, odd = 0;
    public void odd_even()
    {
        for (int i = 0; i < listvalue.Count; i++)
        {
            if (listvalue[i] % 2 == 0)
            {

                even += listvalue[i];
            }
            else
            {
                odd += listvalue[i];
            }
        }
        Console.WriteLine("Sum of Even Numbers" + even);
        Console.WriteLine("Sum of Odd Numbers" + odd);

        Console.ReadKey();
    }
}

public class Specific_Number_4
{
    List<int> listvalue = new List<int> { 2, 4, 19, 130, 135, 58 };
    int number, fin_count, no_count;
    public void input()
    {
        Console.WriteLine("Ask input number:");
        number = Convert.ToInt32(Console.ReadLine());
        findnumber();
    }
    public void findnumber()
    {
        for (int i = 0; i < listvalue.Count; i++)
        {
            if (listvalue[i] == number)
            {
                fin_count++;
                //Console.WriteLine("Found");
                //return;
            }
            else
            {
                no_count++;
                //Console.WriteLine("Not Found");
                //return;
            }
        }
        Console.WriteLine(fin_count != 0 ? "Found" : "Not Found");
        Console.ReadKey();
    }
}



