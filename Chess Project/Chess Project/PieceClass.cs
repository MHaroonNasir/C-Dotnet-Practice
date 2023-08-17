using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Project
{
    class PieceClass
    {
        int X_Coordinate { get; set; }
        int Y_Coordinate { get; set; }
        string Team { get; set; }

        List<List<int>> pieceList = new List<List<int>>();

        public PieceClass()
        {           
        }

        public void addToPieceList(int x_coordinate, int y_coordinate, int teamID)
        {
            pieceList.Add(new List<int> { x_coordinate, y_coordinate, teamID });
        }

        public List<int> ReturnInternalValues(int listX_coord, int listY_coord)
        {
            foreach (List<int> items in pieceList)
            {
                if (items[0] == listX_coord && items[1] == listY_coord)
                {
                    return items;
                    //break; //putting this line here shows a green squiggly saying 'unreachable code'
                    //it is 'unreachable' as when a return statement is given, the method stops, so the break statement is redundant
                }
            }
            throw new InvalidOperationException("No matching co-ords found!");
            //the above throw exception statement can come after the return statement as method is stop functions after the first return statement so the 2 will not overlap
            //return pieceList[0]; //the return of this list<int>
            //return pieceList[0][0]; //since this is 2d, the return type of this is int
        }

        public bool ValidateValuesInList(int x_coordinate, int y_coordinate)
        {
            Console.WriteLine("ValidateValuesInList has ran!");
            foreach (List<int> listItems in pieceList)
            {
                Console.WriteLine(x_coordinate + " " + y_coordinate + " " + listItems[0] + " " + listItems[1]);
                if (listItems[0] == x_coordinate && listItems[1] == y_coordinate)
                {
                    return true;
                }
            }         
            return false;
            //throw new InvalidOperationException("No matching co-ords found!");
            //throw new Exception(false);
        }

        public void DefineMovement()
        {
        }
    }
}
