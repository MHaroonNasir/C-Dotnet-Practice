using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner_Project_8___More_Class_Practice
{
    enum CarEnum //enums are a special class that define group of integral constants
    {//enums can also be declared inside a class and called inside it aswell
        Low, //value 0 //constants are sepereted by , in new line
        Medium, //value 1
        High, //value 2
        //by default, values in enums start with value 0 and increment
        //otherwise enum values can be manually assigned lrather than the incremental values above
        Higher=9,

        //enums are called as below, it is similiar syntax to creating an objetc
        //CarEnum varName = CarEnum.Medium;
        //Console.WriteLine(varName);
        //the enum can also be obtianed by declaring a data type for it
        //int varName = (int)

        //enums are also usefull for switch statements as the integral constants can be used in cases
        /*Level myVar = Level.Medium;
        switch(myVar) 
        {
        case Level.Low:                         //notice how the case number is a integral variable
        Console.WriteLine("Low level");
        break;
        case Level.Medium:
        Console.WriteLine("Medium level");
        break;
        case Level.High:
        Console.WriteLine("High level");
        break;*/
    }
}

