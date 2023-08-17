using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner_Project_8___More_Class_Practice
{
    class CarClass
    {
        //access modifiers
        //'public' - accessible to all
        //'private' - accessible only in same class
        //'protected' - accessible to own class or derived (inherited) classes
        //'internal' - accesible only within it's own assembly
        //'protected internal' - accessible within same assembly it is declared or from derived class from different assembly
        //'private protected' - accessible within declared assembly within same class or in type that is derived from class

        //string colour; //by default the access modifiers of fields (a member of a class) are set to 'private' if not declared

        private string _version; //these are fields

        public string Colour;
        public int MaxSpeed;
        public double EngineSize;
        public string Version //this is a 'property' as it behaves like a hybrid of a method and a field
        {//the purpose of having get and set methods for a variable is for encapsulation, hiding unessecary info from user, this public string string updates the value of it's equivalent private
                    //field as it cannot be edited directly by outside classes
            get //the 'get' and 'set' methods turn this variable into a 'property' rather than a field, in practice, it can called identically directly just like a field can
            {
                return _version.Substring((_version.LastIndexOf(":"))+2); 
            }
            set
            {
                if (value.Contains("A7"))
                {
                    _version = "A Series: " + value;
                }
                else
                {
                    _version = "Undefined: " + value;
                }
            }
        }

        public string SubVersion
        { get; set; } //writing this is a shorthand method of writing the below, also notice that if using this current method, no private variable needs to be declared
        /*private string subVersion;
        public string SubVersion
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }*/
        
        public string Name
        { get; set;  }

        public CarClass(string colour, int maxSpeed, double engineSize, string version, string subVersion = "Sport") //constructors cannot have a return type, 'void' also counts as a return type
        {
            Colour = colour;
            MaxSpeed = maxSpeed;
            EngineSize = engineSize;
            Version = version;
            SubVersion = subVersion;
        }

        public virtual void CarMovement()
        {
            Console.WriteLine("Car go vroom!");
        }

        public void ReturnPrivateAndAssociatedValues()
        {
            Console.WriteLine($"Public and private 'version' value of CarClass:\t[{Version}], [{_version}]");
        }
    }
}
