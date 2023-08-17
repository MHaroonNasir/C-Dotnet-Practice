using System;
using System.IO; //used for 'file' class
using System.Collections.Generic; //used for lists

namespace Chess_Project
{
    class RunGame
    {
        private static int _boardWidth = -1; //width is -1 as a board with 8 piece width has 8+1 number of | per width, the | is what the width is measured as
        private static int _boardHeight = 1;

        private static KingClass kingPiece = new KingClass();
        private static QueenClass queenPiece = new QueenClass();
        private static RookClass rookPiece = new RookClass();
        private static HorseClass horsePiece = new HorseClass();
        private static BishopClass bishopPiece = new BishopClass();
        private static PawnClass pawnPiece = new PawnClass();

        private static Dictionary<string, int> stringToIntTeamIDDictionary = new Dictionary<string, int>() { { "W", 10 }, { "B", 20 } };
        private static Dictionary<int, string> intToStringTeamIDDictionary = new Dictionary<int, string>() { { 10, "W" }, { 20, "B" } };
        /*private static Dictionary<string, object> stringToObjectObjectIDDictionary = new Dictionary<string, object>()
        {
            { "K", kingPiece },
            { "Q", queenPiece },
            { "R", rookPiece },
            { "H", horsePiece },
            { "B", bishopPiece },
            { "P", pawnPiece },
        };*/                            //Note: this dictionary is assigns a key 'strings' to value 'objects', 'objects' are a generic type therefore this dictionary doesn't work
        private static Dictionary<string, PieceClass> StringToObjectObjectIDDictionary = new Dictionary<string, PieceClass>()
        {
            { "K", kingPiece },
            { "Q", queenPiece },
            { "R", rookPiece },
            { "H", horsePiece },
            { "B", bishopPiece },
            { "P", pawnPiece },
        };
        private static Dictionary<string, string> stringToStringTeamDisplayerDictionary = new Dictionary<string, string>() { { "W", "White" }, { "B", "Black" } };
        private static Dictionary<string, string> stringToStringRoleDisplayerDictionary = new Dictionary<string, string>() { 
            { "K", "King" }, 
            { "Q", "Queen" },
            { "R", "Rook" },
            { "H", "Horse" },
            { "B", "Bishop" },
            { "P", "Pawn" },
        };

        enum PieceIDs
        {
            //white = 10s, black = 20s, king = 1, queen = 2, rook = 3, horse = 4, bishop = 5, pawn = 6
            White = 10,
            Black = 20,

            King = 1,
            Queen = 2,
            Rook = 3,
            Horse = 4,
            Bishop = 5,
            Pawn = 6
        }

        static void Main(string[] args)
        {
            //stringToObjectObjectIDDictionary = new Dictionary<string, object>();
            string textFileBoard = ReadTextFile();
            string[,] gameBoard = CreateVisualBoard(textFileBoard);
            PrintVisualBoard(gameBoard);
            List<int> playerPieceChoice = PlayerChoosePiece(gameBoard);
            //PlayerChoosePieceMovement(playerCoordChoice, gameBoard);
            //CreateObjects(gameBoard);
            /*foreach (string counter in gameBoard)
            {
                Console.WriteLine(counter);
            }*/

            /*bool gameWon = false;
            do
            {
                Console.Write("Enter Co-ordinates: ");
                Console.ReadLine();
            } while (gameWon != true);*/

        }

        public static string ReadTextFile()
        {
            string localChessBoard = File.ReadAllText(@"D:\Haroon's Folder\Visual Studio\C#\Chess Project\FullChessBoard.txt");

            Console.WriteLine(localChessBoard);
            /*foreach (int counter in localChessBoard)
            {
                Console.Write($"[{counter}]");
            }*/
            /*Console.WriteLine("£" + localChessBoard.Substring(22, 1) + "*");
            Console.WriteLine("£" + localChessBoard.Substring(23, 1) + "*");
            Console.WriteLine("£" + localChessBoard.Substring(24, 1) + "*");
            Console.WriteLine("£" + localChessBoard.Substring(25, 1) + "*"); //something wrong with this one
            Console.WriteLine("£" + localChessBoard.Substring(26, 1) + "*");
            Console.WriteLine("£" + localChessBoard.Substring(27, 1) + "*");
            Console.WriteLine("£" + localChessBoard.Substring(28, 1) + "*");*/

            return localChessBoard;
        }

        public static void UpdateBoardSizeParameters(string localTextFile)
        {
            foreach (char counter in localTextFile)
            {
                if (counter == '\n' || counter == '|')
                {
                    if (counter == '\n')
                    {
                        _boardHeight += 1;
                    }
                    else if (counter == '|' && _boardHeight == 1)
                    {
                        _boardWidth += 1;
                    }
                }
            }
            Console.WriteLine($"Board Width {_boardWidth}, Board Height {_boardHeight}");
        }

        public static string[,] CreateVisualBoard(string localTextFileBoard)
        {
            //int localBoardWidth = -1;
            //int localBoardHeight = 1;
            UpdateBoardSizeParameters(localTextFileBoard);

            string[,] localGameBoard = new string[_boardWidth, _boardHeight];

            for (int counter = 0; counter < _boardHeight; counter++)
            {
                for (int counter2 = 0; counter2 < _boardWidth; counter2++)
                {
                    //localGameBoard[counter, counter2] = ((counter*10)+10+counter2).ToString();
                    //Console.WriteLine(localGameBoard[counter, counter2]);
                }
            }
            localGameBoard = PopulateVisualBoard(localTextFileBoard, localGameBoard);
            return localGameBoard;
        }

        public static string[,] PopulateVisualBoard(string localTextFile, string[,] gameBoard)
        {
            string localTextFilePieceTeam, localTextFilePieceRole;
            int x_coordinate, y_coordinate, teamID; //value 10 for white team, value 20 for black team
            //Console.WriteLine(localTextFile);
            //Console.WriteLine(localTextFile.Length);

            for (int counter = 1; counter < localTextFile.Length; counter+= 3)
            {
                localTextFilePieceTeam = localTextFile.Substring(counter, 1);
                localTextFilePieceRole = localTextFile.Substring(counter+1, 1);
                //Console.WriteLine($"*****Counter: [{counter}], TeamChar: ({localTextFilePieceTeam}), RoleChar: !{localTextFilePieceRole}\"*****");

                if (localTextFilePieceTeam == "W" || localTextFilePieceTeam == "B")
                {
                    teamID = stringToIntTeamIDDictionary[localTextFilePieceTeam];
                    y_coordinate = Convert.ToInt32(Math.Floor(counter/27.0));
                    x_coordinate = ((counter - (y_coordinate * 27)) / 3);
                    Console.WriteLine($"{x_coordinate}, {y_coordinate}");
                    //if (localTextFilePieceTeam == "W") { teamID = 10; }
                    //else { teamID = 20; }

                    //gameBoard[x_coordinate, y_coordinate] = localTextFilePieceTeam + localTextFilePieceRole;
                    if (localTextFilePieceRole == "K")
                    {
                        kingPiece.addToPieceList(x_coordinate, y_coordinate, teamID);
                        //Console.WriteLine($"Created {localTextFilePieceTeam} King");
                    }
                    else if (localTextFilePieceRole == "Q")
                    {
                        queenPiece.addToPieceList(x_coordinate, y_coordinate, teamID);
                        //Console.WriteLine($"Created {localTextFilePieceTeam} Queen");
                    }
                    else if (localTextFilePieceRole == "R")
                    {
                        rookPiece.addToPieceList(x_coordinate, y_coordinate, teamID);
                        //Console.WriteLine($"Created {localTextFilePieceTeam} Rook");
                    }
                    else if (localTextFilePieceRole == "H")
                    {
                        horsePiece.addToPieceList(x_coordinate, y_coordinate, teamID);
                        //Console.WriteLine($"Created {localTextFilePieceTeam} Horse");
                    }
                    else if (localTextFilePieceRole == "B")
                    {
                        bishopPiece.addToPieceList(x_coordinate, y_coordinate, teamID);
                        //Console.WriteLine($"Created {localTextFilePieceTeam} Bishop");
                    }
                    else if (localTextFilePieceRole == "P")
                    {
                        pawnPiece.addToPieceList(x_coordinate, y_coordinate, teamID);
                        //Console.WriteLine($"Created {localTextFilePieceTeam} Pawn");
                    }
                    gameBoard[y_coordinate, x_coordinate] = localTextFilePieceTeam + localTextFilePieceRole;
                }
            }

            return gameBoard;
        }

        public static void PrintVisualBoard(string[,] localGameBoard)
        {
            Console.Write(" |");
            for (int width = 0; width < _boardWidth; width++)
            {
                Console.Write(width);
                Console.Write(" |");
            }
            Console.Write("\n");
            for (int height = 0; height < _boardWidth; height++)
            {
                Console.Write(height);
                Console.Write("|");
                for (int width = 0; width < _boardWidth; width++)
                {
                    if (localGameBoard[height, width] == null) { Console.Write("  " + "|"); }
                    else { Console.Write(localGameBoard[height, width] + "|"); }
                }
                Console.Write("\n");
            }
        }

        public static List<int> PlayerChoosePiece(string[,] localGameBoard)
        {
            Console.Write("Enter X Co-ordinates: ");
            int userXInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y Co-ordinates: ");
            int userYInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((localGameBoard[userYInput, userXInput]).Substring(1, 1));
            //Console.WriteLine(localGameBoard[userYInput, userXInput]);
            if (localGameBoard[userYInput, userXInput] != null)
            {
                Console.Write("Identified: ");
                //Console.WriteLine(localGameBoard[userYInput, userXInput]);
                Console.Write(stringToStringTeamDisplayerDictionary[localGameBoard[userYInput, userXInput].Substring(0, 1)] + " ");
                Console.WriteLine(stringToStringRoleDisplayerDictionary[localGameBoard[userYInput, userXInput].Substring(1, 1)]);
            }
            else
            {
                Console.WriteLine("Non Identified!");
            }
            //kingPiece.ReturnInternalValues(0, 0);
            //stringToObjectObjectIDDictionary[(localGameBoard[userXInput, userYInput]).Substring(1, 1)]
            bool playerChoiceValid = VerifyPlayerPieceChoice(new List<int> {userXInput, userYInput}, localGameBoard);

            return new List<int> {userXInput, userYInput};
        }

        public static bool VerifyPlayerPieceChoice(List<int> playerCoordChoice, string[,] localGameBoard)
        {
            Console.WriteLine(localGameBoard[playerCoordChoice[1], playerCoordChoice[0]].Substring(1, 1));

            kingPiece.DefineMovement();
            string letter = localGameBoard[playerCoordChoice[1], playerCoordChoice[0]].Substring(1, 1);
            bool results = StringToObjectObjectIDDictionary[letter].ValidateValuesInList(playerCoordChoice[0], playerCoordChoice[1]);
            //testStringToObjectObjectIDDictionary[localGameBoard[playerCoordChoice[1], playerCoordChoice[0]].Substring(1, 1)].ValidateValuesInList;
            Console.WriteLine("Validation Results: " + results);
            results = StringToObjectObjectIDDictionary[letter].ValidateValuesInList(7, 7);
            Console.WriteLine("Validation Results: " + results);
            return results;
        }

        public static List<int> PlayerChoosePieceMovement(List<int> localPieceCoords, string[,] localGameBoard)
        {
            string typeOfMovement = "";
            int userXInput = 0, userYInput = 0;
            while (typeOfMovement != "Successful Attack" || typeOfMovement != "Movement")
            {
                Console.Write("Enter Destination X Co-ordinates: ");
                userXInput = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Destination Y Co-ordinates: ");
                userYInput = Convert.ToInt32(Console.ReadLine());

                VerifyPlayerPieceMovement(localPieceCoords, new List<int> { userXInput, userYInput }, localGameBoard);
            };
            Console.WriteLine("Exiting Loop!");

            return new List<int> { userXInput, userYInput };
        }

        public static string VerifyPlayerPieceMovement(List<int> localPieceCoords, List<int> localDestinationCoords, string[,] localGameBoard)
        {
            string typeOfAttack = "";
            if (localGameBoard[localDestinationCoords[1], localDestinationCoords[0]] != null)
            {
                typeOfAttack = "Attack";
                string turnPieceTeam = localGameBoard[localPieceCoords[1], localPieceCoords[0]].Substring(1, 0);
                string enemyPieceTeam = localGameBoard[localDestinationCoords[1], localDestinationCoords[0]].Substring(1, 0);
                if (turnPieceTeam != enemyPieceTeam)
                {
                    typeOfAttack = "Successful Attack";
                }
                else
                {
                    typeOfAttack = "Unsuccessful Attack";
                }
            }
            else
            {
                typeOfAttack = "Movement";
            }
            return typeOfAttack;
        }

        /*public static void CreateObjects(string[,] visualGameboard)
        {
            List<IPieceBlueprint>[,] pieceList = new List<IPieceBlueprint>[_boardHeight, _boardWidth];
            for (int hCounter = 0; hCounter < _boardHeight; hCounter++)
            {
                for (int wCounter = 0; wCounter < _boardWidth; wCounter++)
                {

                }
            }
        }*/

        /*public static void CreateObjects(int[,] gameBoard)
        {
            int localBoardWidth = _boardWidth;
            int localBoardHeight = 0;

            foreach (int counter in gameBoard)
            {
                if (localBoardWidth == _boardWidth)
                {
                    Console.Write($"\n|{counter}|");
                    localBoardHeight += 1;
                    localBoardWidth = 1;
                }
                else
                {
                    Console.Write($"{counter}|");
                    localBoardWidth += 1;
                }
                //Console.Write(counter);
            }
            Console.WriteLine("\n");

            localBoardWidth = (_boardWidth)-1;
            localBoardHeight = -1;

            for (int counter = 0; counter < (_boardWidth*_boardHeight); counter++)
            {
                if (localBoardWidth == (_boardWidth)-1)
                {
                    localBoardHeight += 1;
                    localBoardWidth = 0;
                    Console.Write($"\n|{gameBoard[localBoardHeight, localBoardWidth]}|");
                }
                else
                {
                    localBoardWidth += 1;
                    Console.Write($"{gameBoard[localBoardHeight, localBoardWidth]}|");
                }
                //Console.Write(counter);
            }
        }*/
    }
}
