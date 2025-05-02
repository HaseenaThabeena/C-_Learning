using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class TwoSum
    {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
        public void getInput()
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();
            int[] num = input.Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Enter the target number:");
            int target = int.Parse(Console.ReadLine());
            Twosum(num, target);
        }
        public void Twosum(int[] num, int target) {
            for (int i = 0; i < num.Length; i++)
            {
                int complement = target - num[i];
                if (numToIndex.ContainsKey(complement))
                {
                    Console.WriteLine($"Indices: {numToIndex[complement]}, {i}");
                    Console.ReadKey();
                    return;
                }
                numToIndex[num[i]] = i;
            }
            
        }
    }
}
