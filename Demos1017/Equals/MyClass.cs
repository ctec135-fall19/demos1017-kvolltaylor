using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    class MyClass
    {

        private int someNumber;
        private string someString;

        public MyClass(int num, string str)
        {
            this.someNumber = num;
            this.someString = str;
        }

        public override bool Equals(object obj)
        {
            //return base.Equals(obj);

            //// comparision
            //// create a temp variable of my type
            //MyClass temp;
            //// have to cast the object paramter to pass myClass
            //// can only compare to objects of same class
            //// hence casting it
            //temp = (MyClass)obj;


            if(obj is MyClass && obj != null)
            {
                MyClass temp;
                temp = (MyClass)obj;

                if ((temp.someNumber == this.someNumber)
                    && temp.someString.Equals(this.someString)) return true;
                else return false;
            }
            return false;
        }
    }
}
