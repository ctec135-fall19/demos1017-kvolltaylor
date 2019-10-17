using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // created 2 differnet objects
    //        // held in 2 different places in memory
    //        MyClass mcl = new MyClass(123, "str1");
    //        MyClass mc2 = new MyClass(123, "str1");

    //        MyClass mc3 = new MyClass(456, "str1");

    //        // does mc1 == mc2
    //        // not comparing values, comparing locations/addresses
    //        // since is two differnt locations, the bool is false
    //        if (mc1 == mc2) Console.WriteLine("mc1 == mc2");
    //        else Console.WriteLine("mc1 does not equal mc2");

    //        // using Equals they have the same values for the internal values
    //        if (mc1.Equals(mc2)) Console.WriteLine("mc1 equals mc2");
    //        else Console.WriteLine("mc1 does not equal mc2");

    //        // 123 is not the same as 456
    //        // no not both the internal values are the same
    //        if (mc1.Equals(mc3)) Console.WriteLine("mc1 equals mc3");
    //        else Console.WriteLine("mc1 does not equal mc3");
    //    }
    //}

    namespace Equals
    {
        class Program
        {
            static void Main(string[] args)
            {
                MyClass mc1 = new MyClass(123, "str1");
                MyClass mc2 = new MyClass(123, "str1");
                MyClass mc3 = new MyClass(456, "str1");
​
            // does mc1 == mc2
            if (mc1 == mc2) Console.WriteLine("mc1 == mc2");
                else Console.WriteLine("mc1 does not equal mc2");
​
            if (mc1.Equals(mc2)) Console.WriteLine("mc1 equals mc2");
                else Console.WriteLine("mc1 does not equal mc2");
​
            if (mc1.Equals(mc3)) Console.WriteLine("mc1 equals mc3");
                else Console.WriteLine("mc1 does not equal mc3");
            }
        }

    }
