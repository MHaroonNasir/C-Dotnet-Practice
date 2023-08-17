using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Project
{
    class RookClass : PieceClass
    {
        public int X_Coordinate
        {
            get;
            set;
        }
        public int Y_Coordinate
        {
            get;
            set;
        }
        public string Team
        {
            get;
            set;
        }

        public List<List<int>> PieceList
        {
            get;
            set;
        }

        public RookClass() : base()
        {

        }

        public void DefineMovement()
        {

        }
    }
}
