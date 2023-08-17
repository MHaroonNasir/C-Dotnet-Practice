using System;
using System.Collections.Generic; //this namespace is necessary for lists to operate

namespace Beginner_Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOString = new List<string> {"text1", "text2"}; //declaration of lists, notice the data type is var and list type is string
            foreach (string counter in listOString) //counter cannot be converted to int type
            {                                       //if an int based loop is needed, check line 38
                Console.WriteLine(counter.ToUpper());
            }

            listOString.Add("testing1"); //add to list
            listOString.Add("testring2");
            listOString.Add("testing3");
            listOString.Remove("text1"); //remove a string from list
            listOString.RemoveAt(0); //remove an item within a specific index
            listOString.RemoveRange(1, 2); //remove items within a range of indeces
            foreach (var counter in listOString)
            {
                Console.WriteLine(counter);
            }

            Console.WriteLine(listOString[0]); //this is how to access individual elements of a list outside of a loop

            //how to find index of a specific element in a large list (no looping method required)
            var listONum = new List<int> { 32, 90, 76, 15, 45, 15, 23, 41, 98, 62, 11, 59, 88, 84, 40, 75, 56 };
            var location = listONum.IndexOf(11); //the IndexOf property takes arguement of the item to be found, returns the index value or if it's not found, it returns -1
            if (location != -1)
            {
                Console.WriteLine($"Index of item in ListONum list is {location}");
            }
            listONum.Sort(); //sorts items in list, works for strings aswell

            //below displays a method of iterating through a list with an int counter rather than string counter, this uses for-loop rather than foreach loop
            //notice how the individual elements of an array are called differently, in this for-loop they are called as list[n] whereas in the foreach loop it is <variable> itself which calls the element
            var fibonacci = new List<int> {1, 1};
            var fibonacciLength = fibonacci.Count;
            Console.WriteLine(fibonacci.Count); //returns the number of indeces in a list
            for (int counter = 0; counter < 9; counter++)
            {
                //var fibonacciLength = fibonacci.Count;
                int lastNum = fibonacci[(fibonacciLength+counter) - 1];
                int lastNum2nd = fibonacci[(fibonacciLength+counter) - 2];
                fibonacci.Add(lastNum + lastNum2nd);
            }
            do
            {
                //var fibonacciLength = fibonacci.Count;
                int lastNum = fibonacci[fibonacci.Count - 1];
                int lastNum2nd = fibonacci[fibonacci.Count - 2];
                fibonacci.Add(lastNum + lastNum2nd);
            } while (fibonacci.Count < 21);

            Console.WriteLine(fibonacci);
            fibonacci.ForEach(Console.WriteLine); //this is a means to print all elements of a list in seperate lines without the need for a loop
            //this works as foreach is a method of a list, therefore it can be used like a for-loop or as an extension to list name
            //console.writeline can be passed as a method group
            Console.WriteLine(string.Format("Example of printing in same line {0}", string.Join(",", fibonacci))); //this is example of printing all list elements in same line
            Console.WriteLine("Example again ({0})", string.Join(",", fibonacci));

            //5 methods of declaring a list (including the first 1 showcased)
            var testList0 = new List<string> { "text1", "text2" };
            List<string> testList = new List<string> {"1", "3"};           
            List<string> testList2 = new List<string> 
            { "1", "3" };           
            int[] testList3 = new int[] { 1, 2 }; //with this method of declaration, if a number is contained within the 2nd [], it specifies the max length of the list
            int[] testList4 = { 1, 2, 3 }; //notice this declaration does not use the 'new' keyword, it can also work with strings, it is practically the same as using the 'new' keyword

            //foreach-loop
            string[] testList50 = { "111", "222", "333" };
            Console.WriteLine(testList3.IsFixedSize + " " + testList50.IsFixedSize);
            foreach (var counter in testList50) //foreach is a specific loop for iteratinmg through a array
            {
                Console.WriteLine(counter);
            }
            testList0[0] = "text100"; //directly assinging a value to an already occupied index of a list
            Console.WriteLine(testList3.Length); //notice, .count works for string lists and .length works for int lists
        }
    }
}
