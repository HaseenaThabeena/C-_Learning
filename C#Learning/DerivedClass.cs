using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class DerivedClass : BaseClass
    {
        public override void getinput()
        {
            Console.WriteLine("Override derived class");
           // base.getinput();
            Console.ReadKey();
        }
    }
}
