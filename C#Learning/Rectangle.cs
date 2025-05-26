using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    //internal class Rectangle
    //{
        ////Sum of Even and Odd Numbers
        //List<int> listvalue = new List<int> { 2, 4, 19, 130, 135, 50, 51, 47, 68, 28 };
        //int even,odd = 0;
        //public void odd_even()
        //{
        //    for(int i=0; i<listvalue.Count;i++)
        //    {
        //        if (listvalue[i] % 2 == 0)
        //        {

        //            even += listvalue[i];
        //        }
        //        else
        //        {
        //           odd += listvalue[i];
        //        }
        //    }
        //    Console.WriteLine("Sum of Even Numbers" + even);
        //    Console.WriteLine("Sum of Odd Numbers" + odd);

        //    Console.ReadKey();
        //}

    
        abstract class Shape
        {
            public abstract int area();
        }

        class Rectangle : Shape
        {
            private int length;
            private int width;

            public Rectangle(int a = 0, int b = 0)
            {
                length = a;
                width = b;
            }
            public override int area()
            {
                Console.WriteLine("Rectangle class area :");
                return (width * length);
            }
        }
    //    class RectangleTester
    //    {
    //        static void Main(string[] args)
    //        {
                
    //            Console.ReadKey();
    //        }
        
    //}






//}
}
