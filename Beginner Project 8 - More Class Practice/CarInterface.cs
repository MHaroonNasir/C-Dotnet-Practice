using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner_Project_8___More_Class_Practice
{
    interface ICarInterface //an interface is a fully abstract class, the class members it can contain are methods and properties but not fields
    {//by default, the members in this struct are 'abstract' and 'public', therefore these keywords do not need to be declared when defining methods or properties
        //it is also considered good to start interfaces with 'I' letter
        //interfaces are implemented rather than inherited, but in practice the syntax is same using : just like with inheritance
        //additionally the 'override' keyword is not needed by derived classes to replace functionality of a method, all methods of the interface must be overriden
        //interface cannot contain constructor as it is 'abstract' by nature, it cannot be used to create objects

        //C# does not support multiple inheritance, a single class can only inherit from 1 class but it does support multiple implementations from interfaces
    }
}
