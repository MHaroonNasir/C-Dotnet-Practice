using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectList
{
    class RookClass : PieceClass
    {
        public RookClass(int x, int y) : base(x, y)
        {
            
        }

        public override void PrintPrivateValues()
        {
            Console.WriteLine($"Private Values: {this.xCoordinate} {this.yCoordinate}");
        }
        public override void SimpleMethod()
        {
            Console.WriteLine("Method of Rook Class has been called!!!");
        }
        public override string SimpleMethod1()
        {
            return "Method of Rook Class has been called111";
        }

    }
}
