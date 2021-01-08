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
            //Get the ordinal positions of both squares
            int fromColumn = GetOrdinal(char.Parse(squareFrom.Substring(0, 1))); //1-8
            int fromRow = int.Parse(squareFrom.Substring(1, 1));
            int toColumn = GetOrdinal(char.Parse(squareTo.Substring(0, 1)));
            int toRow = int.Parse(squareTo.Substring(1, 1));

            if(GetSquare(squareFrom) == Pieces.Knight)
            {
                //Calculate relative position deltas
                var deltaUp = Math.Abs(toRow - fromRow);
                var deltaRight = Math.Abs(toColumn - fromColumn);

                //Check if the piece is allowed to move to the destination square
                if (deltaUp == 2 && deltaRight == 1)
                {
                    board[squareTo] = board[squareFrom];
                    board[squareFrom] = Pieces.Empty;
                }
                else
                    throw new InvalidOperationException();
            }

            else if (GetSquare(squareFrom) == Pieces.Bishop)
            {
                //Calculate relative position deltas
                var deltaUp = toRow - fromRow;
                var deltaRight = toColumn - fromColumn;

                //Check to see if the bishop is moving diagonally 
                if (deltaUp > 0 && deltaRight > 0 && deltaUp % deltaRight == 0 && deltaRight % deltaUp == 0)
                {
                    board[squareTo] = board[squareFrom];
                    board[squareFrom] = Pieces.Empty;
                }
                else
                    throw new InvalidOperationException();
            }

        }

        private int GetOrdinal(char column)
        {
            switch (column)
            {
                case 'A':
                    return 1;
                case 'B':
                    return 2;
                case 'C':
                    return 3;
                case 'D':
                    return 4;
                case 'E':
                    return 5;
                case 'F':
                    return 6;
                case 'G':
                    return 7;
                case 'H':
                    return 8;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
