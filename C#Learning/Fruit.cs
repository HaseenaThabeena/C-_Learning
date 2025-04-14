using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Fruit
    {
        string fruit;
        string size;
        public void getinput()
        {
            Console.WriteLine("Enter the Fruit : (Apple, Banana, Orange) : ");
            fruit = Console.ReadLine();
            Console.WriteLine("Enter the size : (Small, Medium, Large) : ");
            size = Console.ReadLine();
        }
        public void Display()
        {
            if (fruit == "")
            {
                Console.WriteLine("Empty");
            }
            else if(fruit =="Apple" || fruit=="Banana" || fruit == "Orange")
            {
                Console.WriteLine("Valid Fruit");
            }
            switch (size)
            {
                case "Small":
                    Console.WriteLine($"The fruit {fruit} and the size is {size}");
                    break;
                case "Medium":
                    Console.WriteLine($"The fruit {fruit} and the size is {size}");
                    break;
                case "Large":
                    Console.WriteLine($"The fruit {fruit} and the size is {size}");
                    break;
                default:
                    Console.WriteLine("Not valid size");
                    break;
            }
            Console.ReadKey();

        }
    }
}
