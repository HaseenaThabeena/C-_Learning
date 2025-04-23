using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Circlecircum
    {
        const double pi = 3.14;
        double r, circumference;
        
        public void getInput()
        {
            Console.WriteLine("Enter the radius");
            r = Convert.ToDouble(Console.ReadLine());
            calculate();
        }
        public void calculate()
        {
            circumference =2 *pi*r;
            Console.WriteLine("Circle Circumference {0}", circumference);
            Console.ReadKey();
        }
        
    }
}
