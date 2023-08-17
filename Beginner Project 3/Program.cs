using System;

namespace Beginner_Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;
            bool lean1 = true; //boolean declaration
            bool lean2 = num1 + num2 > 10; //boolean statements can also be stored as a boolean equation
            if (num1 < num2)
            {
                Console.WriteLine($"Num1 ({num1}) is smaller than Num2 ({num2})");
            }
            else if (num1 == num2)
            {
                Console.WriteLine($"Num1 ({num1}) is equal to Num2 ({num2})");
            }
            else
            {
                Console.WriteLine($"Num2 ({num2}) is smaller than Num1 ({num1})");
            }
            //a code block is that which is contained with {}

            if (num1 < num2)
                Console.WriteLine($"Num1 ({num1}) is smaller than Num2 ({num2})");
            else
                Console.WriteLine($"Num2 ({num2}) is smaller than Num1 ({num1})\n");
            //if else statements can be written encased in {} or without, {} is required if more than 1 statement are executed after condition
            //== (EQUALITY), && (AND), || (OR)
            //= is assingment as seen in variable declaration whereas == is equality

            //there is additional way of reformatting simple if-statements
            int numberSimple = 5;
            string stringSimple = (numberSimple < 4) ? "less than 4" : "equal to or greater than 4";
            //the syntax is as follows: <variable> = <condition> ? <value of variable if true> : <value of variable if false>;
            Console.WriteLine("stringSimple = " + stringSimple);
            //writing the above declaration of stringSimple is equivalent to writing the if-statement below
            /*if (numberSimple < 4)
                stringSimple = "less than 4";
            else
                stringSimple = "equal to or greater than 4";*/

            //switch-case statement
            //switch-case and if-statements are identical in practice, however is a long list of conditions need to be checked, switch-cases are more efficient
            //their biggest difference is if-statements can have statements against many variety of conditions whereas switch-case only does so against ints, enumerated values and string objects
            //the expression at the beginning is checked against each case
            switch(numberSimple) //this is the expression
            {
                case 500:                   //cases can consist of any int, if the expression above matches this int, it executes code block
                    Console.WriteLine("Case 500");
                    break;                  //'break' keyword is used to break out of current code block and stop execution for more test cases
                case 600:
                    Console.WriteLine("Case 600");
                    break;
                default:                    //this case is executed when no other match with a case is found above, it is equivalent to 'else' of if-statement
                    Console.WriteLine("No other match");
                    break;
            }

            for (int counter = 0; counter < 11; counter += 2) //the iteration within the 3rd segments of for loops can be increment by different values rather than always ++
            {
                if (counter == 4)
                {                 
                    continue; //the 'continue' keyword can used in for and while loops, it breaks the current iteration, whereas 'break' keyword will break the entire loop
                    //in this scenario, eventhough the console.writeline does not exist within the if-statement codeblock, this entire interation is broken with 'continue' so the number 4 is skipped
                }
                Console.WriteLine(counter);
            }

            //while-loop
            int num3 = 0;
            while (num3 < 5)
            {
                Console.WriteLine($"While-loop count is {num3}");
                num3++; //increase value of num3 by 1
            }

            //do-while loop
            //the difference between do-while and while loop is that do-while indefinately run at least once before checking exit condition
            //the while loop however will check exit conidition before first iteration
            num3 = 0; //notice how the data type is not declared as the variable already exists
            do
            {
                Console.WriteLine($"Do-while loop count is {num3}");
                num3++;
            } while (num3 < 5);
            //while (num3 < 5); //the while can be placed in the same line as end-bracket or the line after

            Console.WriteLine("\n");
            //for-loop
            for (int num4 = 0; num4 < 5; num4++) //notice that the new variable is declared in the for-loop, this is not optional
            //the first section is the initialiser, second is condition and third is iterator
            //any variable declared in the for-loop initialiser exists for the for-loop context only, once the loop is terminated the variable inside no longer exists
            {
                Console.WriteLine($"For-loop count is {num4}");
            }
            //Console.WriteLine(num4); //as such, the variable that was used to initialise cannot be printed outside the for-loop

            int num5 = 5;
            for(; num5 < 10; num5++)
            //however, if a counter variable is desired beyond the for-loop, it can be decalred before hand and the initialiser can just contain a ;
            {
                Console.WriteLine($"For-loop count is {num5}");
            }
            Console.WriteLine(num5); //therefore, variable used in for-loop can be printed outside the for-loop

            Console.WriteLine("\n");
            char letter = 'a'; //this is how char is declared, notice that char uses ' whereas string uses "
            for (; letter < 'h'; letter++) //single letters (chars) can be treated like numerbers and therefore can be compared other other chars, less or more than and can be iterated upon
            {
                Console.WriteLine($"Letter is ({letter})");
            }

            for (int counter = 0; counter < 3; counter++)
            {
                for (char alp = 'a'; alp < 'd'; alp++)
                {
                    Console.WriteLine($"Counter ({counter}), Letter ({alp})");
                }
            }

            for (char alp = 'a'; alp < 'd'; alp++)
            {
                for (int counter = 0; counter < 3; counter++)
                {
                    Console.WriteLine($"Counter ({counter}), Letter ({alp})");
                }
            }

            Console.WriteLine("\n");
            int sum = 0;
            for (int counter = 3; counter <= 20; counter++)
            {
                if (counter % 3 == 0)
                {
                    sum = sum + counter;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
