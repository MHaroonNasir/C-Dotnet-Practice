using System;

namespace Beginner_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;  //no need for "" with ints
            //int b = a + a;
            Console.WriteLine(a + a);   //can do numeric calculations inside writeline

            //an int variable which is the result of a non-int value (such as 11/3) is store an int value anyway
            //example:
            int num1 = 11;
            int num2 = 3;
            int num3 = num1 / num2; //this will return an int value eventhough it should be a decimal
            int numtest = 11 / 3;
            Console.WriteLine($"\n{num3}, {numtest}"); //this will display an int value eventhough it should be a decimal
            Console.WriteLine(90 + 9);
            Console.WriteLine("example of concatenation with strings and ints " + num1 + 9);
            //concatenation will occur whenever a string is present along with int values
            //in line 20, output will be 99 as only ints are present in the statement
            //however in line 21, becuase a string is present, concatenation will occur and the output of the numbers will be 119 instead of 20
            Console.WriteLine("example of concatenation with strings and ints " + (num1 + 9)); //to prevent concatenation, ()s are needed

            string test1 = "text1";
            string test2 = "text2";
            Console.WriteLine(test1, test2); //strings can be written in writeline comman with no "" and seperate by commas, but ints cannot
            //Console.WriteLine(num1, num2); //this is invalid, numerical values cannot be written in writeline command without $ and ""

            //% is (modulus) the remainder value
            int num4 = 11 % 3; //it will return the int remainder value of calculation
            Console.WriteLine($"\n{num4}");
            Console.WriteLine($"C# ints have limits to thei value. These are {int.MaxValue} and {int.MinValue}.");
            //above shows the max and min values for C# ints, these numbers are 2,147,483,647 and -2,147,483,648, ints cannot go BEYOND these values but can touch them
            //otherwise they are stated as overflow and underflow
            //if under-overflow does occur, the number will go to the opposite end of the limit
            //example: if overflow happens through maxValue+3, the value will instead become the minValue+2, it will go in a loop

            //double is double precision floating point number, floating means that number is non-integer and double precision is term to describe number of binary digits
            //double precision has double the number of binary digits than single precision
            double num5 = 11 / 3;
            Console.WriteLine($"\nDouble float: {num5}"); //this will return an int value, double are influenced by the data type of the object they are a combination of
            Console.WriteLine(11/3); //this also returns int value
            double b = 11;
            double c = 3;
            double d = b / c;
            //doubles are affected by the data types of the variables they manipulate, if 'b' and 'c' were int values, 'd' would still return int despite being a double
            //only 'b' or 'c' needs to be a double to have 'd' be double, but if both are int, 'd' is also int
            Console.WriteLine(d);
            Console.WriteLine($"Double max-min values: {double.MaxValue}, {double.MinValue}");
            //1.7976931348623157E+308, -1.7976931348623157E+308

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
            //this is an example of a rounding error in C#, that value is 1/3 however what is returned 0.33333

            //decimal have a smaller range but greater precision than doubles
            Console.WriteLine($"\nDecimal Range: {decimal.MaxValue}, {decimal.MinValue}");
            //below is example of decimals greater precision
            decimal third2 = 1.0M / 3.0M; // the 'M' suffix is used to tell the compiler that the number is a decimal, otherwise the compiler will treat it like a double
            //whenever a float number is used, the 'M' suffix is needed if that number is to be treated as a decimal, otherwise by default it will be a double
            Console.WriteLine(third2);
            //the letter 'M' is the most notable letter distinction from double and decimal

            double pi = Math.PI;
            double circleRadius = 2.5;
            double circleArea = pi*Math.Pow(circleRadius, 2.0);
            Console.WriteLine(circleArea);

            //in specific situations were ints are used in division but an accurate value needs to be provided even if it is decimal, ints can be implicitly converted to decimcal
            //this is called 'casting' a data type
            //to cast int as decimal, casting operator is () and this operator alongside the name of the data-type to be converted to is written before the value
            int num6 = 11;
            int num7 = 3;
            decimal num8 = (decimal)num6 / (decimal)num7; //here the ints are being casted(an implicit data conversion) to decimal
            Console.WriteLine("\n" + num8);

            //'casting' means to assign the value of 1 data type to another
            //there is implicit (automatically) converting from a smaller data type to a larger
            //char > int > long > float > double (heirarchy of data type sizes)
            //explicit (manual) casting is from the larger data type sizes to the smallest, so the above heirarchy is reversed
            int casting = 10;
            double casting1 = casting; //this is implicit (automatic) casting, when this value is printed, it comes out as an integer
            double casting2 = 10.999D;
            int casting3 = (int) casting2; //this is explicit (manual) casting, the value returned is always rounded down
            //there also exist conversion methods
            //Convert.To<> //this method is used for conversion, use intellisense to see the various types of options for conversion within the <>

            int num9 = 9;
            num9 += 9; //alongside this, -=, *= are valid
            num9++; //increamenting, -- is valid for decrementing
            //depending on where ++ is placed, it increments a value before or after an execution

            Console.WriteLine(num9); //this will print 19 becuase of previous operations
            Console.WriteLine(num9++); //this will still print 19 becuase the incrementing takes place AFTER the print statement is finished
            Console.WriteLine(num9); //this will now print 20 beucase the variable was incremented before
            Console.WriteLine(++num9); //this will print 21 as the incrementing takes place before the print statement

            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32) * (5M / 9M);
            Console.WriteLine(celsius);
            //showcase of fahrenheit conversion to celsius
            //notice that the 5/9 are labelled as decimal values with the M postfix
            //this is becuase 5/9 is a decimal value and if the M postfix was not there they would be treated like ints and the value would be 0, which is the wrong calculation 
        }
    }
}
