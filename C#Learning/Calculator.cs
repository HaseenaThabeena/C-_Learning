using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Calculator
    {
        int a;
        int b;
        //int d;
        public void getInput()
        {
            Console.WriteLine("Enter the Value for A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for B");
            b = Convert.ToInt32(Console.ReadLine());
            Functions();
        }
        public void Functions()
        {
            Console.WriteLine("Enter the Options");
            Console.WriteLine("1.Add" );
            Console.WriteLine("2.Sub" );
            Console.WriteLine("3.Multiply" );
            Console.WriteLine("4.Division" );
            Console.WriteLine("5.Modlous" );
            Console.WriteLine("6.Exit");
            int c = Convert.ToInt32(Console.ReadLine());
            while(c != 6)
            {

            }
            switch (c)
            {
                case 1:
                    Console.WriteLine("Add Result" + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Sub Result" + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiply Result" + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Division Result" + (a / b));
                    break;
                case 5:
                    Console.WriteLine("Mod Result" + (a % b));
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid...!!!");
                    break;
            }

            //Console.WriteLine("Do You Want to continue ?");
            //Console.WriteLine("Enter Options");
            //Console.WriteLine("1.Yes");
            //Console.WriteLine("2.No");
            //d = Convert.ToInt32(Console.ReadLine());

            //if (d == 1)
            //{
            //   getInput();
            //}
            //else
            //{
            //    Console.WriteLine("Thank you");
            //    return;
            //}
         
            Console.ReadKey();
           
        }
    }
}
