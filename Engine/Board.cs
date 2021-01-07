using System;
using System.Collections.Generic;

namespace Engine
{
    public class Board
    {
        private Dictionary<string, string> board = new Dictionary<string, string>();

        public Board()
        {
            //Row 1
            board[Squares.A1] = Pieces.Rook;
            board[Squares.B1] = Pieces.Knight;
            board[Squares.C1] = Pieces.Bishop;
            board[Squares.D1] = Pieces.Queen;
            board[Squares.E1] = Pieces.King;
            board[Squares.F1] = Pieces.Bishop;
            board[Squares.G1] = Pieces.Knight;
            board[Squares.H1] = Pieces.Rook;

            //Row 2
            board[Squares.A2] = Pieces.Pawn;
            board[Squares.B2] = Pieces.Pawn;
            board[Squares.C2] = Pieces.Pawn;
            board[Squares.D2] = Pieces.Pawn;
            board[Squares.E2] = Pieces.Pawn;
            board[Squares.F2] = Pieces.Pawn;
            board[Squares.G2] = Pieces.Pawn;
            board[Squares.H2] = Pieces.Pawn;
            
            //Row 3
            board[Squares.A3] = Pieces.Empty;
            board[Squares.B3] = Pieces.Empty;
            board[Squares.C3] = Pieces.Empty;
            board[Squares.D3] = Pieces.Empty;
            board[Squares.E3] = Pieces.Empty;
            board[Squares.F3] = Pieces.Empty;
            board[Squares.G3] = Pieces.Empty;
            board[Squares.H3] = Pieces.Empty;
            
            //Row 4
            board[Squares.A4] = Pieces.Empty;
            board[Squares.B4] = Pieces.Empty;
            board[Squares.C4] = Pieces.Empty;
            board[Squares.D4] = Pieces.Empty;
            board[Squares.E4] = Pieces.Empty;
            board[Squares.F4] = Pieces.Empty;
            board[Squares.G4] = Pieces.Empty;
            board[Squares.H4] = Pieces.Empty;
            
            //Row 5
            board[Squares.A5] = Pieces.Empty;
            board[Squares.B5] = Pieces.Empty;
            board[Squares.C5] = Pieces.Empty;
            board[Squares.D5] = Pieces.Empty;
            board[Squares.E5] = Pieces.Empty;
            board[Squares.F5] = Pieces.Empty;
            board[Squares.G5] = Pieces.Empty;
            board[Squares.H5] = Pieces.Empty;

            //Row 6
            board[Squares.A6] = Pieces.Empty;
            board[Squares.B6] = Pieces.Empty;
            board[Squares.C6] = Pieces.Empty;
            board[Squares.D6] = Pieces.Empty;
            board[Squares.E6] = Pieces.Empty;
            board[Squares.F6] = Pieces.Empty;
            board[Squares.G6] = Pieces.Empty;
            board[Squares.H6] = Pieces.Empty;

            //Row 7
            board[Squares.A7] = Pieces.Pawn;
            board[Squares.B7] = Pieces.Pawn;
            board[Squares.C7] = Pieces.Pawn;
            board[Squares.D7] = Pieces.Pawn;
            board[Squares.E7] = Pieces.Pawn;
            board[Squares.F7] = Pieces.Pawn;
            board[Squares.G7] = Pieces.Pawn;
            board[Squares.H7] = Pieces.Pawn;

            //Row 8
            board[Squares.A8] = Pieces.Rook;
            board[Squares.B8] = Pieces.Knight;
            board[Squares.C8] = Pieces.Bishop;
            board[Squares.D8] = Pieces.Queen;
            board[Squares.E8] = Pieces.King;
            board[Squares.F8] = Pieces.Bishop;
            board[Squares.G8] = Pieces.Knight;
            board[Squares.H8] = Pieces.Rook;
        }

        public string GetSquare(string square) => board[square];

        public void MovePiece(string squareFrom, string squareTo)
        {
            board[squareTo] = board[squareFrom];
            board[squareFrom] = Pieces.Empty;
        }
    }

    public class Squares
    {
        public const string A1 = "A1";
        public const string B1 = "B1";
        public const string C1 = "C1";
        public const string D1 = "D1";
        public const string E1 = "E1";
        public const string F1 = "F1";
        public const string G1 = "G1";
        public const string H1 = "H1";

        public const string A2 = "A2";
        public const string B2 = "B2";
        public const string C2 = "C2";
        public const string D2 = "D2";
        public const string E2 = "E2";
        public const string F2 = "F2";
        public const string G2 = "G2";
        public const string H2 = "H2";

        public const string A3 = "A3";
        public const string B3 = "B3";
        public const string C3 = "C3";
        public const string D3 = "D3";
        public const string E3 = "E3";
        public const string F3 = "F3";
        public const string G3 = "G3";
        public const string H3 = "H3";

        public const string A4 = "A4";
        public const string B4 = "B4";
        public const string C4 = "C4";
        public const string D4 = "D4";
        public const string E4 = "E4";
        public const string F4 = "F4";
        public const string G4 = "G4";
        public const string H4 = "H4";

        public const string A5 = "A5";
        public const string B5 = "B5";
        public const string C5 = "C5";
        public const string D5 = "D5";
        public const string E5 = "E5";
        public const string F5 = "F5";
        public const string G5 = "G5";
        public const string H5 = "H5";

        public const string A6 = "A6";
        public const string B6 = "B6";
        public const string C6 = "C6";
        public const string D6 = "D6";
        public const string E6 = "E6";
        public const string F6 = "F6";
        public const string G6 = "G6";
        public const string H6 = "H6";

        public const string A7 = "A7";
        public const string B7 = "B7";
        public const string C7 = "C7";
        public const string D7 = "D7";
        public const string E7 = "E7";
        public const string F7 = "F7";
        public const string G7 = "G7";
        public const string H7 = "H7";

        public const string A8 = "A8";
        public const string B8 = "B8";
        public const string C8 = "C8";
        public const string D8 = "D8";
        public const string E8 = "E8";
        public const string F8 = "F8";
        public const string G8 = "G8";
        public const string H8 = "H8";
    }

    public class Pieces
    {
        public const string King = "King";
        public const string Queen = "Queen";
        public const string Rook = "Rook";
        public const string Knight = "Knight";
        public const string Bishop = "Bishop";
        public const string Pawn = "Pawn";
        public const string Empty = "";
    }
}
