using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // compiler wont let you do the below:
            //AbstractBaseClass abc = new AbstractBaseClass();

            ChildClass cc = new ChildClass();
            Console.WriteLine(cc.AbstractMethod(123));

        }
    }
}
