using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Missingnum
    {
        public void MissingNumber(int[] nums)
        {
            int result = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= i ^ nums[i];
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
       
    }
}
