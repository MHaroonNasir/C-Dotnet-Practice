using System;
using System.Collections.Generic;

namespace ObjectList
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objectList1 = new object[] { };
            List<object> objectList2 = new List<object>();

            string[] stringList1 = new string[] { };
            List<string> stringList2 = new List<string> { };

            var list1 = new List<string> { };

            try
            {
                foreach (int counter in objectList1)
                {
                    Console.WriteLine($"Object {counter} in ObjectList: {objectList1[counter]}");
                }
            }
            catch
            {
                Console.WriteLine("Failed 111");
            }

            Console.WriteLine("After execution!");
            RookClass rookObject1 = new RookClass(0, 0);
            RookClass rookObject2 = new RookClass(1, 1);

            rookObject1.SimpleMethod();

            objectList2.Add(rookObject1);
            objectList2.Add(null);
            objectList2.Add(rookObject2);
            //objectList2[0].SimpleMethod();
            Console.WriteLine(objectList2);
            foreach (Object counter in objectList2)
            {
                Console.WriteLine($"Object {counter} in ObjectList: {counter}");
            }

            for (int counter = 0; counter < objectList2.Count; counter++)
            {
                //objectList2[counter].SimpleMethod();
                Console.WriteLine($"Counte number {counter} and method call: {objectList2[counter]}");
            }

            List<PieceClass> classList = new List<PieceClass>();
            classList.Add(new RookClass(2, 2));
            foreach (var counter in classList)
            {
                counter.SimpleMethod();
                //Console.WriteLine($"ClassList: {counter}, {counter.SimpleMethod()}");
                Console.WriteLine($"ClassList: {counter}, {counter.XCoordinate}, {counter.YCoordinate}");
                Console.WriteLine("ClassList {0} {1}", counter.XCoordinate, counter.YCoordinate);
            }
            /*foreach (Object counter in classList)
            {
                counter.SimpleMethod();
                Console.WriteLine($"ClassList: {counter}, {counter.SimpleMethod()}");
                Console.WriteLine("ClassList {0} {1}", counter.XCoordinate, counter.YCoordinate);
            }*/
            foreach (var counter in classList)
            {
                counter.SimpleMethod1();
                Console.WriteLine($"ClassList: {counter}, {counter.SimpleMethod1()}, {counter.XCoordinate}, {counter.YCoordinate}");
                Console.WriteLine("ClassList {0} {1}", counter.XCoordinate, counter.YCoordinate);
            }
            /*foreach (object counter in classList)
            {
                counter.SimpleMethod1();
                Console.WriteLine($"ClassList: {counter}, {counter.SimpleMethod1()}");
                Console.WriteLine("ClassList {0} {1}", counter.XCoordinate, counter.YCoordinate);
            }*/

            classList[0].PrintPrivateValues();

            classList.Add(new RookClass(3, 3));
            classList.Add(new RookClass(4, 4));
            classList.Add(null);
            classList.Add(new RookClass(5, 5));
            Console.WriteLine("ClassList length", classList.Count);
            for (int counter = 0; counter < classList.Count; counter ++)
            {
                Console.WriteLine($"Counter {counter}, ClassList {classList[counter]}");
            }

            string longText = "1234567890";
            Console.WriteLine(longText.Substring(3, 1));

            List<int> intList = new List<int>();
            List<int> intList2 = new List<int> { 1, 1, 1 };
            //intList.Add(intList2); //cannot add a list to 1D list, conversion error, also cannot include multiple arguements in 'add' method

            //List<int>[,] intList3 = new int[1,3]; //this is not correct
            int[,] intList4 = { { }, { }, { } };
            //List<int>[,] intList5 = new List<int>[,]();
            //intList5[0] = [ 1, 1, 1 ];
            //intList5[0, 1] = [1, 1, 1];
            //the above 3 lines are wrong


            List<List<int>> intList6 = new List<List<int>>();
            intList6.Add(new List<int> { 1, 11, 111 });
            intList6.Add(new List<int> { 2, 22, 222 });
            intList6.Add(new List<int> { 3, 33, 333 });
            Console.WriteLine(intList6);
            Console.WriteLine($"{intList6[0]} {intList6[1]} {intList6[2]}");
            Console.WriteLine($"{intList6[0][0]} {intList6[0][1]} {intList6[0][2]}");
            //Console.WriteLine($"{intList6[0, 0]} {intList6[0, 1]} {intList6[0, 2]}"); //this is wrong
            List<int> intList7 = new List<int> { 1, 2, 3};
            int[] intList8 = new int[3] { 1, 2, 3 };
            int[] intList9 = { 1, 2, 3 };
            Console.WriteLine(intList7);
            Console.WriteLine(intList8);
            Console.WriteLine(intList9);
            //note: simply printing a list gives an unusable result

            Console.WriteLine((5 + 5).ToString());
        }
    }
}
