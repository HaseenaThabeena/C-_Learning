using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Enum
    {
        enum Day
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday            
        }
      
        public void showday()
        {
            Day days = Day.Thursday;
            switch (days)
            {
                case Day.Sunday:
                    Console.WriteLine("Its a Sunday");
                    break;
                case Day.Monday:
                    Console.WriteLine("Its a Monday");
                    break;
                case Day.Tuesday:
                    Console.WriteLine("Its a Tuesday");
                    break;
                case Day.Wednesday:
                    Console.WriteLine("Its a Wednesday");
                    break; 
                case Day.Thursday:
                    Console.WriteLine("Its a Thursday");
                    break; 
                case Day.Friday:
                    Console.WriteLine("Its a Friday");
                    break; 
                case Day.Saturday:
                    Console.WriteLine("Its a Saturday");
                    break;
            }
            Console.ReadKey();
        }

    }
}
