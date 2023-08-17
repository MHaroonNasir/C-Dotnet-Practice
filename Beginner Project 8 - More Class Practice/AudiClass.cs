using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner_Project_8___More_Class_Practice
{
    class AudiClass : CarClass
    {
        public AudiClass(string colour = "Bright red", int maxSpeed = 160, double engineSize = 3.0, string version = "A7 TSFI e", string subVersion = "S Line") : base(colour, maxSpeed, engineSize, version, subVersion)
        {

        }

        public override void CarMovement() //the the CarClass.CarMovement() was not declared as 'virtual', this method will not have 'override' keyword but will still work as intended
        { //but the compiler will give  awarning, not an error, to get rid of the warning, use the 'new' keyword at the beginning declaration of this mehthod
            Console.WriteLine("Audi go vroom!");
        }//virtual-override and new are functionally identical here
    }
}
