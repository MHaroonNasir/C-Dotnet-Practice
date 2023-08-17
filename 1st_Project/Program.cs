using System; //this is a namespace called system, they contain types and other namespaces. the 'console' class in the body of the function is an example of a type whereas
              //'IO' and 'Collections' are example of other namespaces for the 'system' namespace (see example 1 line below of specific namespace of 'system' being called)
//using System.IO;

//the 'using' directive allows unqualified use of a namespace, allowing for the 'console' type to be used as a shorthand for System.Console.WriteLine

namespace _1st_Project //'_1st_Project' is the 'fully qualified name' of the class
{
    class Program   //classname is 'program'
    {
        static void Main(string[] args) //method name is 'main', declared with a static modifier. static methods operate without reference to an object, making a static method
        {                               // called 'main' the entry way for a C# program
            Console.WriteLine("Hello World!");
        }
    }
}

//there are 2 kinds of types in C#, value types and reference types
//variables of values types directly contain their data whereas variables of reference types store references to their data, latter is known as objects
//therefore if 2 variables have the same reference type, alter 1 can alter the reference of the other variable
//whereas as with value types, each variable will have its own copy therefore changing 1 does not affect the other

//identifiers are variable names

//key organisational concepts are; programs, namespaces, types, members and assemblies
//PROGRAMS declare TYPES, which contain MEMBERS and can be organised into NAMESPACES.
//(classes, structs, interfaces are examples of types. fields, methods, properties and events are examples of members)
//when program is complied, they are packed into assemblies which have file extension .exe or .dll depending on whether they implement applications or libraries respectively

//classes
//data structure that combines state (fields) and action (methods, function members) in single unit
//class provides definition for objects, which are instances of a class
//(inheritance, polymorphism)
//class declarations start with header, which specify; attributes and modifiers, name, base class (when inheriting from a base class), interfaces implemented

//objects (instances of a class) a created with 'new' operator
//example: var p1 = new Point(0, 0);            a variable data type with name 'p1' is an instance of a class called 'point' which takes 2 arguements
//memory is allocated for new incstance, the construtor is incoked to initialise the instance and returns a REFERENCE to instance, not VALUE type



//type parameters
//classes can use type parameters, which are a list of type parameter names in angled brackets
//example: public class Pair<TFirst, TSecond>           a class named 'pair' with 2 type parameters
//they can be used in the body of class declaration to define members of the class

//base classes
//to delcare a class as having a base class (inheriting from), the name and type parameters of a class are followed by : and then base class name
//example: public class Point3D : Point         a class named 'point3d' with no type parameters but base class named 'point'
//in inheritance, a class inherits almost all members of its base class, it does not inherit; instance and static constructors and the finalisers
//derived class (subclass) can add new members to those it inherited but cannot remove definitions of the inherited members
// a variable that is is of a type class (instead of str, int etc... to create an object/instance, classname is used as type) can reference itself or any subclass
//example: there is a superclass called 'BaseS' and its subclass (a class that inherited from the superclass) is called 'DerS'
//example cont.: BaseS name1 = new BaseS(arguement1);
//example cont.: BaseS name2 = new DervS(arguement1, aruguement2);
//the question here is: what is the difference when useing type as superclass to create an object/instance of a subclass rather than just using the type as subclass to create subclass object?
//example: whats the difference when doing 
//                                          BaseS name2 = new DervS(arguement1, aruguement2);
//                                          DervS name2 = new DervS(arguement1, aruguement2);
//                                          (notice the change in the variable type declaration at the start)

//structs
//classes define types that support inheritance and polymorphism and are based on heirachy of derived (inherited) classes
//contrastly, structs are simple types that are only used to store data values
//structs cannot declare base type (something to inherit from), nor can structs derive from other struct types. all struct types instead derive from 'Sytem.ValueType'

//interfaces
//they define contract that can be implemented by classes or structs. interfaces contains methods, properties, events and indexers
//interfaces usually do not provide implementation of members they define, they instead mostly specifies the members that must be supplied by classes or structs when they implement interface
//interfaces can do multiple inheritance
//example: interface IComboBox : ITextBox, IListBox { }             after the colon, two interfaces are declare as base types, these interfaces can also be derived from other interfaces
//classes and structs can implement multiple interfaces
//example: public class EditBox : IControl, IDataBound
//when a class or struct implements a interface, their created objects can be converted to interface type
//example: EditBox editBox = new EditBox();
//example: IControl control = editBox;
//a class named 'editbox', exists which implements a interface, and an object is created by declaring the type as the class name
//a interface object is beig created by using the type as the interface name and the value of it is the name of the class object
//not sure why this is the case?????????????????

//enum
//they define set of constant values
//they can also be used in combination as flags
//they also have their unique method of declaration

//variables of any type can be declared as non-nullable or nullable
//nullable means the variable can hold an extra value, which is the 'null' value

//C# supports tuples which are used to group multiple data elements which can be used to structure data with multiple members 
