using System;

namespace DelegatesTest
{
    class Program
    {
        public delegate void delegate1(string value);
        //delegate syntax:
        //<protection level> delegate <return type> <name>(return values);
        //<protection> is optional

        public delegate void delegateSquared(delegate delegate1);

        public static void printStatement1(string str)
        {
            Console.WriteLine("Testing Text123" + str);
        }
        public static void printStatement2(string str)
        {
            Console.WriteLine("Toast123" + str);
        }

        public static void printStatement3(string str)
        {
            Console.WriteLine("T123" + str);
        }

        static void Main(string[] args)
        {
            delegate1 object1 = new delegate1(printStatement1);
            delegate1 object2 = new delegate1(printStatement2);
            delegate1 object3 = new delegate1(printStatement3);
            object1("manman");
            object2("manman");
            object3("manman")
        }
    }
}
