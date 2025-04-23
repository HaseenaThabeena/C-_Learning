using System;

namespace C_Learning
{
    internal class Comparsion
    {
        int number,d, out_number,operators, a_number = 10;
        
        public void getInput()
        {
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Operations \n1.+=\n2.-=\n3.*=\n4./=\n5.%= \n6.Exit");
            operators = Convert.ToInt32(Console.ReadLine());
            compare();
        }
        public void compare()
        {
            switch (operators)
            {
                case 1:
                    Console.WriteLine("Number value {0}" , number += a_number);
                    break;
                case 2:
                    Console.WriteLine("Number value {0}", number -= a_number);
                    break;
                case 3:
                    Console.WriteLine("Number value {0}", number *= a_number);
                    break;
                case 4:
                    Console.WriteLine("Number value {0}", number /= a_number);
                    break;
                case 5:
                    Console.WriteLine("Number value {0}", number %= a_number);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid...!!!");
                    break;


            }
            Console.WriteLine("Do You Want to continue ? \nEnter Options\n1.Yes\n2.No");
            d = Convert.ToInt32(Console.ReadLine());

            if (d == 1)
            {
                getInput();
            }
            else
            {
                Console.WriteLine("Thank you");
                return;
            }
            Console.ReadKey();
          
        }
    }
}
