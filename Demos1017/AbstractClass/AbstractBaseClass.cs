using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class AbstractBaseClass
    {
        // no curly brackets, no code
        // instantiate an abstract base class it's providing a contract
        // saying the children are goint to implement a method

        // abstract base classes can also define methods that are
        // common to all the children
        // can at least require method creating contract requiring all 
        // children to use the method
        // its a contract that you have to satisfy that all children will do "this"
        // only applies to the one class hierarchy

        public abstract int AbstractMethod(int num);

    }
}
