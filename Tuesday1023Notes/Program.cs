using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuesday1023Notes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

// Object Oriented Programming Concepts
//  Polymorphism:
//        The ability for methods to be overridden in child classes and
//        methods of the same name to be overloaded
//        Also allows child classes to be referenced as objects of the same
//        type as their parent class
//  Abstraction:
//        Allows classes to be non-specific regarding the values of properties
//        and fields, while maintaining a dynamic(change using {get;set;}) state
//  Encapsulation:
//        Organization of local variables, methods, and constructors within each class
//  Inheritance:
//        Allows child classes to inherit the properties, fields, and methods of
//        parent classes(BUT NEVER CONSTRUCTORS)


//  Access Modifiers
//    public: 
//      allows access from anywhere within the project
//    protected:
//      only allows access from within the class itself and child classes
//    private:
//      can only be accessed from within the class itself
//    internal:
//      can only be accessed within the class library/assembly
//      (think using System; there are methods that can only be used
//      within the System class, we can't use them in our code!)
//	  protected internal:
//      combination of protected and internal, only allows access
//      from within the class and the class's children within the
//		class library/assembly
//    sealed:
//      methods and classes with the sealed modifier cannot be extended
//      or have any children

//  Abstract Classes:
//	    can be used to hold information for children classes
//	    CANNOT BE USED TO CREATE AN OBJECT
//	    abstract methods have no body(code to run) and cannot be private
//	    if a class has any abstract methods, the class itself must be abstract
//      ----------- SEE Shape.cs FOR EXAMPLE -----------
//            ADVANTAGES:
//              Can use instance and static variables, as well as constants
//              Can define regular methods that contain code (concrete methods) and abstract methods
//              Can define fields

//  Interfaces:
//      special type of coding element that provides many advantages of multiple inheritance
//      defines a set of public methods that can be implemented by a class
//      ********A CLASS THAT IMPLEMENTS AN INTERFACE MUST PROVIDE AN IMPLEMENTATION FOR EACH METHOD DEFINED BY THE INTERFACE********
//      can inherit from one or more other interfaces
//      ********CANNOT INHERIT FROM A CLASS********
//      ----------- Ask Cheri for repl.it example -----------
//            ADVANTAGES:
//              A class can implement (inherit) multiple interfaces
//              Any object created from a class that implements an interface can be used wherever the interface is accepted