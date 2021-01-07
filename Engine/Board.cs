using System;
using System.Collections.Generic;

namespace Engine
{
    public class Board
    {
        private Dictionary<string, string> board = new Dictionary<string, string>();

        public Board()
        {
            board[Squares.A1] = Pieces.Rook;
            board[Squares.B1] = Pieces.Knight;
            board[Squares.C1] = Pieces.Bishop;

            board[Squares.A2] = Pieces.Pawn;
            board[Squares.B2] = Pieces.Pawn;
            board[Squares.C2] = Pieces.Pawn;

            board[Squares.A3] = Pieces.Empty;
            board[Squares.B3] = Pieces.Empty;
            board[Squares.C3] = Pieces.Empty;
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

        public const string A2 = "A2";
        public const string B2 = "B2";
        public const string C2 = "C2";

        public const string A3 = "A3";
        public const string B3 = "B3";
        public const string C3 = "C3";
    }

    public class Pieces
    {
        public const string Rook = "Rook";
        public const string Knight = "Knight";
        public const string Bishop = "Bishop";
        public const string Pawn = "Pawn";
        public const string Empty = "";
    }
}
