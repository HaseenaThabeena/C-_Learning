using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Digitcheck
    {
        string str;
        bool isAllDigits = true;

        public void getInput()
        {
            Console.WriteLine("Enter the String");
            str = Console.ReadLine();
            output();
        }
        public void output()
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    isAllDigits = false;
                    break;
                }
            }

            if (isAllDigits)
                Console.WriteLine("The string contains only digits.");
            else
                Console.WriteLine("The string contains non-digit characters.");

            Console.ReadKey();
        }
    }
}
