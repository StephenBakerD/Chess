using System;
using System.Collections.Generic;
using Engine.Pieces;

namespace Engine
{
    public class Board
    {
        public Dictionary<string, IPiece> Squares { get; private set; }

        public Board()
        {
            Squares = new Dictionary<string, IPiece>()
            {
                { Engine.Squares.A1, null },
                { Engine.Squares.B1, null },
                { Engine.Squares.C1, null },
                { Engine.Squares.D1, null },
                { Engine.Squares.E1, null },
                { Engine.Squares.F1, null },
                { Engine.Squares.G1, null },
                { Engine.Squares.H1, null },

                { Engine.Squares.A2, null },
                { Engine.Squares.B2, null },
                { Engine.Squares.C2, null },
                { Engine.Squares.D2, null },
                { Engine.Squares.E2, null },
                { Engine.Squares.F2, null },
                { Engine.Squares.G2, null },
                { Engine.Squares.H2, null },

                { Engine.Squares.A3, null },
                { Engine.Squares.B3, null },
                { Engine.Squares.C3, null },
                { Engine.Squares.D3, null },
                { Engine.Squares.E3, null },
                { Engine.Squares.F3, null },
                { Engine.Squares.G3, null },
                { Engine.Squares.H3, null },

                { Engine.Squares.A4, null },
                { Engine.Squares.B4, null },
                { Engine.Squares.C4, null },
                { Engine.Squares.D4, null },
                { Engine.Squares.E4, null },
                { Engine.Squares.F4, null },
                { Engine.Squares.G4, null },
                { Engine.Squares.H4, null },

                { Engine.Squares.A5, null },
                { Engine.Squares.B5, null },
                { Engine.Squares.C5, null },
                { Engine.Squares.D5, null },
                { Engine.Squares.E5, null },
                { Engine.Squares.F5, null },
                { Engine.Squares.G5, null },
                { Engine.Squares.H5, null },

                { Engine.Squares.A6, null },
                { Engine.Squares.B6, null },
                { Engine.Squares.C6, null },
                { Engine.Squares.D6, null },
                { Engine.Squares.E6, null },
                { Engine.Squares.F6, null },
                { Engine.Squares.G6, null },
                { Engine.Squares.H6, null },

                { Engine.Squares.A7, null },
                { Engine.Squares.B7, null },
                { Engine.Squares.C7, null },
                { Engine.Squares.D7, null },
                { Engine.Squares.E7, null },
                { Engine.Squares.F7, null },
                { Engine.Squares.G7, null },
                { Engine.Squares.H7, null },
                              
                { Engine.Squares.A8, null },
                { Engine.Squares.B8, null },
                { Engine.Squares.C8, null },
                { Engine.Squares.D8, null },
                { Engine.Squares.E8, null },
                { Engine.Squares.F8, null },
                { Engine.Squares.G8, null },
                { Engine.Squares.H8, null }
            };
        }

        public Board(Dictionary<string, IPiece> squares) : this()
        {
            foreach(var square in squares.Keys)
            {
                Squares[square] = squares[square]; //TODO: Fix naming
            }
        }

        public static Board CreateStandardBoard()
        {
            
            //{
            //    { Engine.Squares.A1, new Rook() },
            //    { Engine.Squares.B1, new Knight() },
            //    { Engine.Squares.C1, new Bishop() },
            //    { Engine.Squares.D1, new Queen() },
            //    { Engine.Squares.E1, new King() },
            //    { Engine.Squares.F1, new Bishop() },
            //    { Engine.Squares.G1, new Knight() },
            //    { Engine.Squares.H1, new Rook() },

            //    { Engine.Squares.A2, new Pawn() },
            //    { Engine.Squares.B2, new Pawn() },
            //    { Engine.Squares.C2, new Pawn() },
            //    { Engine.Squares.D2, new Pawn() },
            //    { Engine.Squares.E2, new Pawn() },
            //    { Engine.Squares.F2, new Pawn() },
            //    { Engine.Squares.G2, new Pawn() },
            //    { Engine.Squares.H2, new Pawn() },

            //    { Engine.Squares.A3, null },
            //    { Engine.Squares.B3, null },
            //    { Engine.Squares.C3, null },
            //    { Engine.Squares.D3, null },
            //    { Engine.Squares.E3, null },
            //    { Engine.Squares.F3, null },
            //    { Engine.Squares.G3, null },
            //    { Engine.Squares.H3, null },

            //    { Engine.Squares.A4, null },
            //    { Engine.Squares.B4, null },
            //    { Engine.Squares.C4, null },
            //    { Engine.Squares.D4, null },
            //    { Engine.Squares.E4, null },
            //    { Engine.Squares.F4, null },
            //    { Engine.Squares.G4, null },
            //    { Engine.Squares.H4, null },

            //    { Engine.Squares.A5, null },
            //    { Engine.Squares.B5, null },
            //    { Engine.Squares.C5, null },
            //    { Engine.Squares.D5, null },
            //    { Engine.Squares.E5, null },
            //    { Engine.Squares.F5, null },
            //    { Engine.Squares.G5, null },
            //    { Engine.Squares.H5, null },

            //    { Engine.Squares.A6, null },
            //    { Engine.Squares.B6, null },
            //    { Engine.Squares.C6, null },
            //    { Engine.Squares.D6, null },
            //    { Engine.Squares.E6, null },
            //    { Engine.Squares.F6, null },
            //    { Engine.Squares.G6, null },
            //    { Engine.Squares.H6, null },

            //    { Engine.Squares.A7, new Pawn()},
            //    { Engine.Squares.B7, new Pawn()},
            //    { Engine.Squares.C7, new Pawn()},
            //    { Engine.Squares.D7, new Pawn()},
            //    { Engine.Squares.E7, new Pawn()},
            //    { Engine.Squares.F7, new Pawn()},
            //    { Engine.Squares.G7, new Pawn()},
            //    { Engine.Squares.H7, new Pawn()},

            //    { Engine.Squares.A8, new Rook()},
            //    { Engine.Squares.B8, new Knight()},
            //    { Engine.Squares.C8, new Bishop()},
            //    { Engine.Squares.D8, new Queen()},
            //    { Engine.Squares.E8, new King()},
            //    { Engine.Squares.F8, new Bishop()},
            //    { Engine.Squares.G8, new Knight()},
            //    { Engine.Squares.H8, new Rook() }
            //};

            return new Board();
        }

        public List<string> GetPossibleMoves(string fromSquare)
        {
            var result = new List<string>();
            var piece = Squares[fromSquare];

            foreach (var toSquare in Squares.Keys)
            {
                if(piece.TryMove(toSquare))
                {
                    result.Add(toSquare);
                }
            }

            return result;
        }
    }
}
