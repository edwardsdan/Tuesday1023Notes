using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuesday1023Notes
{
    // because the class has an abstract method, it has to be abstract
    // this means I can't instantiate a Shape object, only make children of it

    abstract class Shape    // encapsulation because it's a class
    {                       // 
        protected string Name; //// field holds information for children
        public virtual void PrintName() //// method can be overridden by children
        {
            Console.WriteLine(Name);
        }
        public abstract double GetArea(); //// abstract method for children, add code in children classes
    }
}
