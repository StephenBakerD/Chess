using System;
using System.Collections.Generic;
using Engine.Pieces;

namespace Engine
{
    public class Board
    {
        private Dictionary<string, IPiece> squares = new Dictionary<string, IPiece>();

        public Board()
        {
            //Row 1
            squares[Squares.A1] = new Rook();
            squares[Squares.B1] = new Knight();
            squares[Squares.C1] = new Bishop();
            squares[Squares.D1] = new Queen();
            squares[Squares.E1] = new King();
            squares[Squares.F1] = new Bishop();
            squares[Squares.G1] = new Knight();
            squares[Squares.H1] = new Rook();

            //Row 2
            squares[Squares.A2] = new Pawn();
            squares[Squares.B2] = new Pawn();
            squares[Squares.C2] = new Pawn();
            squares[Squares.D2] = new Pawn();
            squares[Squares.E2] = new Pawn();
            squares[Squares.F2] = new Pawn();
            squares[Squares.G2] = new Pawn();
            squares[Squares.H2] = new Pawn();

            //Row 3
            squares[Squares.A3] = null;
            squares[Squares.B3] = null;
            squares[Squares.C3] = null;
            squares[Squares.D3] = null;
            squares[Squares.E3] = null;
            squares[Squares.F3] = null;
            squares[Squares.G3] = null;
            squares[Squares.H3] = null;

            //Row 4
            squares[Squares.A4] = null;
            squares[Squares.B4] = null;
            squares[Squares.C4] = null;
            squares[Squares.D4] = null;
            squares[Squares.E4] = null;
            squares[Squares.F4] = null;
            squares[Squares.G4] = null;
            squares[Squares.H4] = null;

            //Row 5
            squares[Squares.A5] = null;
            squares[Squares.B5] = null;
            squares[Squares.C5] = null;
            squares[Squares.D5] = null;
            squares[Squares.E5] = null;
            squares[Squares.F5] = null;
            squares[Squares.G5] = null;
            squares[Squares.H5] = null;

            //Row 6
            squares[Squares.A6] = null;
            squares[Squares.B6] = null;
            squares[Squares.C6] = null;
            squares[Squares.D6] = null;
            squares[Squares.E6] = null;
            squares[Squares.F6] = null;
            squares[Squares.G6] = null;
            squares[Squares.H6] = null;

            //Row 7
            squares[Squares.A7] = new Pawn();
            squares[Squares.B7] = new Pawn();
            squares[Squares.C7] = new Pawn();
            squares[Squares.D7] = new Pawn();
            squares[Squares.E7] = new Pawn();
            squares[Squares.F7] = new Pawn();
            squares[Squares.G7] = new Pawn();
            squares[Squares.H7] = new Pawn();

            //Row 8
            squares[Squares.A8] = new Rook();
            squares[Squares.B8] = new Knight();
            squares[Squares.C8] = new Bishop();
            squares[Squares.D8] = new Queen();
            squares[Squares.E8] = new King();
            squares[Squares.F8] = new Bishop();
            squares[Squares.G8] = new Knight();
            squares[Squares.H8] = new Rook();
        }

        public IPiece GetSquare(string square) => squares[square];

        public bool TryMovePiece(string squareFrom, string squareTo)
        {
            var success = GetSquare(squareFrom).TryMove(squareFrom, squareTo, GetSquare(squareTo));

            if (success)
            {
                squares[squareTo] = squares[squareFrom];
                squares[squareFrom] = null;
            }

            return success;
        }
    }
}
