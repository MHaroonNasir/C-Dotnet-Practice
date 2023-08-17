using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Project
{
    class QueenClass : PieceClass
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

        public QueenClass() : base()
        {

        }

        public void DefineMovement()
        {

        }
    }
}
