using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Temp
    {
        double temperature;
        bool isValid;
        public void getInput()
        {
            Console.WriteLine("Enter Temperature");
            isValid = double.TryParse(Console.ReadLine(), out temperature);
            checktemp();
        }
        public void checktemp()
        {
            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.ReadKey();
                return;
            }
            if (temperature > 30)
            {
                Console.WriteLine("Hot day");
            }
            else
            {
                Console.WriteLine("Cool day");
            }
            Console.ReadKey();
        }
    }
}
