using System;
using System.Collections.Generic;
using Engine.Pieces;

namespace Engine
{
    public class Board
    {
        private Dictionary<string, IPiece> squares = new Dictionary<string, IPiece>();

        public Board(Dictionary<string, IPiece> pieces)
        {
            foreach (var piece in pieces)
            {
                squares[piece.Key] = piece.Value;
            }
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

        public static Dictionary<string, IPiece> NormalPieceArrangement
        {
            get
            {
                return new Dictionary<string, IPiece>()
                {
                    { Squares.A1, new Rook() },
                    { Squares.B1, new Knight() },
                    { Squares.C1, new Bishop() },
                    { Squares.D1, new Queen() },
                    { Squares.E1, new King() },
                    { Squares.F1, new Bishop() },
                    { Squares.G1, new Knight() },
                    { Squares.H1, new Rook() },

                    { Squares.A2, new Pawn() },
                    { Squares.B2, new Pawn() },
                    { Squares.C2, new Pawn() },
                    { Squares.D2, new Pawn() },
                    { Squares.E2, new Pawn() },
                    { Squares.F2, new Pawn() },
                    { Squares.G2, new Pawn() },
                    { Squares.H2, new Pawn() },

                    { Squares.A3, null },
                    { Squares.B3, null },
                    { Squares.C3, null },
                    { Squares.D3, null },
                    { Squares.E3, null },
                    { Squares.F3, null },
                    { Squares.G3, null },
                    { Squares.H3, null },

                    { Squares.A4, null },
                    { Squares.B4, null },
                    { Squares.C4, null },
                    { Squares.D4, null },
                    { Squares.E4, null },
                    { Squares.F4, null },
                    { Squares.G4, null },
                    { Squares.H4, null },

                    { Squares.A5, null },
                    { Squares.B5, null },
                    { Squares.C5, null },
                    { Squares.D5, null },
                    { Squares.E5, null },
                    { Squares.F5, null },
                    { Squares.G5, null },
                    { Squares.H5, null },

                    { Squares.A6, null },
                    { Squares.B6, null },
                    { Squares.C6, null },
                    { Squares.D6, null },
                    { Squares.E6, null },
                    { Squares.F6, null },
                    { Squares.G6, null },
                    { Squares.H6, null },

                    { Squares.A7, new Pawn()},
                    { Squares.B7, new Pawn()},
                    { Squares.C7, new Pawn()},
                    { Squares.D7, new Pawn()},
                    { Squares.E7, new Pawn()},
                    { Squares.F7, new Pawn()},
                    { Squares.G7, new Pawn()},
                    { Squares.H7, new Pawn()},

                    { Squares.A8, new Rook()},
                    { Squares.B8, new Knight()},
                    { Squares.C8, new Bishop()},
                    { Squares.D8, new Queen()},
                    { Squares.E8, new King()},
                    { Squares.F8, new Bishop()},
                    { Squares.G8, new Knight()},
                    { Squares.H8, new Rook() }
                };
            }
        }
    }
}
