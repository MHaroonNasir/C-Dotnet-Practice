﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Project
{
    class PawnClass : PieceClass
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

        public PawnClass() : base()
        {

        }

        public void DefineMovement()
        {

        }
    }
}
