using System;

namespace Beginner_Project_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //the line above is also an example of invoking a method from a class and passing values into it

            Random dice = new Random(); //this is a refeence of a new object
            int diceRoll = dice.Next(1, 10);
            //this is a creating a new instance of system.random and storing the reference to a new object it in variable called 'diceroll'
            //next the method of an object instance is called, this method is called next which return a non-negative int and accepts 2 arguements and the return value is stored in variablke
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(diceRoll);
                diceRoll = dice.Next(1, 10);
            }

            //the difference between console.writeline method and 'Random' class method is that 1 is 'STATELESS (STATIC) METHOD' and 1 is 'STATEFUL (INSTANCE) METHOD'
            //a stateless (static) method DOES NOT RELY upon a STATE, whereas a stateful (instance) method DOES RELY upon a STATE
            //a state is a description of an execution environment in its current state, this means any code that has been executed and any avlues that have been stored in memory as a result
            //console.writeline is stateless as it does not require any values stored in memory to operate, and its output does not edit the state in any capacity, it is self-contained in a way
            //console.random however relies on a state as it needs variables to be stored so that object instances can created of it for it to be invoked
            //it also alters the state as well, creating new values that need to be stored in memory
            //the description of stateless and stateful-ness are also complementary of the fact that another defintion of 'static' to belong to a program class rather than an object (instance) of the program class
            //since creating an object would alter the state of the program since it will need to be stored in memory, a non-static method will belong to a object of the program class

            //when methods are defined, the variables within their () are called as parameters
            //when a method of an object is created and variables are passed into the method call, that is called arguements
            //default values can be used within the parameter on a method definition using the = opertor, then when that method is called through object and arguement of it is not included
            //in (), the method will take the default value defined in parameters
            //it is also possible to pass arguements in methods using 'key : value' syntax therefore the order of the arguments no longer needs to align with the order of the parameters
            //example: static void AMethod(int num1, string str1, int num2);
            //AMethod(str1 : "string", num2 : 5, num1 : 6);

            //when a method is to return a value. it will not have 'void' in its definition line but will have a datat-type before the method name
            //static int AMethod(string parameter 1, int parameter 2) //defining a method with return value, notice the int near the beginning as it will return int
            //if calling a method which returns data, it can be stored in variable
            //example: int number = AMethod(string arguement 1, int arguement 2); //also notice the method is called directly without a object as that method is defined as 'static' and therefore stateless

            //method overloading
            //this is the practice of having multiple methods which have the same name, but MUST have difference in types AND/OR number of parameters
            //static int SumOfAllNumbers(int num1, int num2)
            //static int SumOfAllNumbers(int num1, int num2, int 3)
            //static double SumOfAllNumbers(double num1, double num2)

            //instance of a class is called object, they are created using 'new' operator
            //this operator does 3 important things
            //1. requests address in memory which is big enough to store object of the specified class
            //2. creates new object and store in memory address
            //3. returns memory address so it can be saved in specifiec variable

            //void methods are those that do not return values
            //input paramters are defined by using a data type, so the method cannot except data types it is not expecting
            //A method signature is the number of input parameters defined for each input parameter and the data type (unclear of this meaning)
            //an overloaded method is defined with multiple method signatures, they offer different methods of being called or providing different data

            //some overloaded versions of a method allow for sending or different data types whereas other allow for input of more (or less) input paramters
            //considering console.writeline, it has 19 overloaded versions, these overloaded versions allow for different data types to be entered (str, int, double etc)
            //the 'Random' class has the .next() methods which has 3 overloaded versions, these version can only accept int data types but allow for more or less input parameters
            //int roll1 = dice.Next();
            //int roll2 = dice.Next(101);
            //int roll3 = dice.Next(50, 101);
            //the first version of the Next() method doesn't set an upper and lower boundary, so the method will return values ranging from 0 to 2,147,483,647, which is the maximum value an int can store.
            //The second version of the Next() method specifies the maximum value as an upper boundary, so in this case, we can expect a random value between 0 and 100.
            //The third version of the Next() method specifies both the minimum and maximum values, so in this case, we can expect a random value between 50 and 100.
        }
    }
}
