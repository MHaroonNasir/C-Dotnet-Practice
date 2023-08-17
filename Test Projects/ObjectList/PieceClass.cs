using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectList
{
    class PieceClass
    {
        protected int xCoordinate;
        protected int yCoordinate;

        public int XCoordinate
        {
            get; set;
        }

        public int YCoordinate
        {
            get; set;
        }

        public PieceClass(int x, int y)
        {
            this.XCoordinate = x;
            this.YCoordinate = y;
        }

        public virtual void SimpleMethod()
        {

        }

        public virtual string SimpleMethod1()
        {
            return "";
        }

        public virtual void PrintPrivateValues()
        {

        }
    }
}
