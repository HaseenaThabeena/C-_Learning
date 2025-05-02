using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class SingleNumber
    {
        public void getInput()
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();
            int[] nums = input.Split(' ').Select(int.Parse).ToArray();
            FindSingleNumber(nums);
        }
        public void FindSingleNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    i++; 
                }
                else
                {
                    Console.WriteLine($"The number that appears only once is: {nums[i]}");
                    Console.ReadKey();
                    return;
                }
            }                
        }    
    }
}
