using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Project
{
    interface IPieceBlueprint
    {
        int X_Coordinate { get; set; } //interface cannot house fields, only properties and method, by default all properties are 'public'
        int Y_Coordinate { get; set; }
        string Team { get; set; }

        void DefineMovement(); //by default, all methods inside an interface are 'public' and 'abstract', so these keywords are not needed
    }
}
