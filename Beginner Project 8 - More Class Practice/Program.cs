using System;
using System.IO;

namespace Beginner_Project_8___More_Class_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //choosing either of the 2 different methods of initialising an object below are a stlye preference, there is no optimisation advantage from either
            //although the first option is preferred as it is clearer
            CarClass audiV7 = new CarClass("White", 155, 3.0, "A7 Sportback");
            AudiClass audiA7 = new AudiClass();
            //var audiR8 = new CarClass();

            audiV7.Colour = "Navy Blue"; //directly changing a field of this object
            Console.WriteLine($"Colour: {audiV7.Colour}");

            audiV7.ReturnPrivateAndAssociatedValues();
            audiA7.ReturnPrivateAndAssociatedValues(); //notice that the method of tha base class can be called for the derived class which does nto have this method defined

            audiV7.CarMovement();
            audiA7.CarMovement();

            string fileContents = File.ReadAllText(@"D:\Haroon's Folder\Visual Studio\C#\Beginner Project 8 - More Class Practice\Project8_Notepad.txt");
            Console.WriteLine($"\n[{fileContents}]");
            string excelContents = File.ReadAllText(@"D:\Haroon's Folder\Visual Studio\C#\Beginner Project 8 - More Class Practice\Project8_Excel.xlsx");
            Console.WriteLine($"\n[{excelContents}]");
            //closing of files is important, this method automtically closes files, also important to include file extension
        }
    }
}
