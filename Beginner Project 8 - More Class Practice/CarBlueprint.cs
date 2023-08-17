using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner_Project_8___More_Class_Practice
{
    abstract class CarBlueprint //interfaces and the 'abstract' keyword for classes is for achieving data abstraction, hiding unessecary data from user
    {//abstract class cannot be used to create objects, it can only be accessed if inherited and then objects can be created from that derived class
        public abstract void BodyKit(); //an 'abstract' method can only be in a 'abstract' class or interface, it has no body as it is defined by the derived class
        //the dervied class method must use 'override' keyword just like if this method was 'virtual'
        public void Remodel() //'abstract' classes can have normal methods aswell
        {
            Console.WriteLine("Vehicle is remodelled");
        }
    }
}
