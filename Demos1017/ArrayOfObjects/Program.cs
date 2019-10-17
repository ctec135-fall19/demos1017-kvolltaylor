using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 123;
            double d = 456.789;
            string s = "some string";
            myClass mc = new myClass();

            Object[] myArray = new object[4];
            myArray[0] = i;
            myArray[1] = d;
            myArray[2] = s;
            myArray[3] = mc;

            // example of polymorphism
            foreach(object o in myArray)
            {
                // calling common methods in the object classs
                Console.WriteLine(o.GetType());
                Console.WriteLine(o.ToString());
                Console.WriteLine();
            }
        }
    }
}
