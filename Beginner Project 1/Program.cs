using System;

namespace Beginner_Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //literal values are those that are hard-coded and never change, the above string is a literal value as it is not part of a variable

            string var1 = "This is a variable value.";
            string var2 = "###2";
            string var3 = "###3";
            Console.WriteLine(var1);
            Console.WriteLine("Concatination? " + var2);
            Console.WriteLine($"String Interpolation, This is aparently a better method than the previous. {var2}");
            //the $ at the beginning of "" is necessary for strin interpolation, the variable is encased in {} is inside the ""
            //the literal string in the console.writeline command become template when prefixed with $
            const string var10 = "constant string"; //these are how constant variables are defioned, with the 'const' keyword at the beginning
            //var10 = "string"; //this is invalid as it is a constant it cannot be changed

            Console.Write("Line 1. ");
            Console.Write("Line 2. ");
            Console.Write("Line 3. ");
            //the .write method of console allows for printing in same line, .write does not have current line terminator like .writeline does

            Console.WriteLine($"\nString Interpolation, example 2. {var2} and {var3}");
            int var4 = var2.Length;
            //there are plenty of options for a string which can be explored by a '.' at end of string
            Console.WriteLine($"Can define the property of a string within writeline or in variable. {var4}, or can do this {var3.Length}.");

            string var5 = "     Hello World!     ";
            string var6 = var5.Trim();
            string var7 = var5.Replace("World", "Dlrow");
            Console.WriteLine("\n[" + var6 + "]");
            var6 = var5.TrimEnd();
            Console.WriteLine("[" + var6 + "]");
            var6 = var5.TrimStart();
            Console.WriteLine("[" + var6 + "]");
            Console.WriteLine("[" + var7 + "]");

            Console.WriteLine(var7.ToLower());
            Console.WriteLine(var7.ToUpper());

            Console.WriteLine($"\n{var5.Contains("Wor")}"); //returns boolean statement if a substring is contained in string
                                                            //when created string properties, a new variable can be created to holdthe string property (such as var6) or it can be done as 1 time only by doing so in writeline command

            //\n and \t are 2 popular escape characters, \\ and \" are also escape characters which allow \ and " to be printed in message
            Console.WriteLine(@"Line number 1
                                Line number 2
                                    Line Number 3
                            Line number 4");
            //the @ directive allows a single console.writeline command to occupy and print in multiple lines without the need for \n escape character
            //it also prevents the need for any escape characerters, all escape characters can be removed except \"
            Console.WriteLine(@"\fed\wec\n\n\n\n\t\t\t");

            //whitespace is reffered to anything that is a space, tab or new line
            //compiler ignores whitespace so the following code produces valid outputs
            // Example 1:
            Console
            .
            WriteLine
            (
            "Hello World!"
            )
            ;
            // Example 2:
            string firstWord = "Hello"; string lastWord = "World"; Console.WriteLine(firstWord + " " + lastWord + "!");

            //taking user input
            Console.Write("\nAwaiting input: ");
            string userInput = Console.ReadLine(); //this is the method of capturing user input, no message can be placed inside the parenthesis like with 'Python', therefore writeline should be before
            //int userInput1 = Console.ReadLine(); //.readline method always returns a string, therefore this line of code is invalid and cannot be stored in a int
            Console.WriteLine("Awaiting numerical input in new line: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine()); //however 'casting' (converting) through the convert.to method can be used, casting is explained in next beginner project
            //however, note that format exception will be thrown if wrong data type will be thrown
            Console.WriteLine("User inputs was: " + userInput + " " + userInput2);
        }
    }
}
