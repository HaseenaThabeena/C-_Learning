using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Exception
    {
        int[] numbers = { 1, 2, 3 };
        public void arrayadd()
        {
            try
            {
                Console.WriteLine("Accessing element: " + numbers[5]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("outout" + ex.Message);
                //throw;
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }

    }
}
