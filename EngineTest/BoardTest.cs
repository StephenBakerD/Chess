using Engine;
using Engine.Pieces;
using Xunit;
using System;

namespace EngineTest
{
    public class BoardTest
    {
        private Board board;

        public BoardTest()
        {
            board = new Board();
        }

        [Theory]
        [InlineData(Squares.A1, Rook.Name)]
        [InlineData(Squares.B1, Knight.Name)]
        [InlineData(Squares.C1, Bishop.Name)]
        [InlineData(Squares.D1, Queen.Name)]
        [InlineData(Squares.E1, King.Name)]
        [InlineData(Squares.F1, Bishop.Name)]
        [InlineData(Squares.G1, Knight.Name)]
        [InlineData(Squares.H1, Rook.Name)]

        [InlineData(Squares.A2, Pawn.Name)]
        [InlineData(Squares.B2, Pawn.Name)]
        [InlineData(Squares.C2, Pawn.Name)]
        [InlineData(Squares.D2, Pawn.Name)]
        [InlineData(Squares.E2, Pawn.Name)]
        [InlineData(Squares.F2, Pawn.Name)]
        [InlineData(Squares.G2, Pawn.Name)]
        [InlineData(Squares.H2, Pawn.Name)]

        [InlineData(Squares.A3, null)]
        [InlineData(Squares.B3, null)]
        [InlineData(Squares.C3, null)]
        [InlineData(Squares.D3, null)]
        [InlineData(Squares.E3, null)]
        [InlineData(Squares.F3, null)]
        [InlineData(Squares.G3, null)]
        [InlineData(Squares.H3, null)]

        [InlineData(Squares.A4, null)]
        [InlineData(Squares.B4, null)]
        [InlineData(Squares.C4, null)]
        [InlineData(Squares.D4, null)]
        [InlineData(Squares.E4, null)]
        [InlineData(Squares.F4, null)]
        [InlineData(Squares.G4, null)]
        [InlineData(Squares.H4, null)]

        [InlineData(Squares.A5, null)]
        [InlineData(Squares.B5, null)]
        [InlineData(Squares.C5, null)]
        [InlineData(Squares.D5, null)]
        [InlineData(Squares.E5, null)]
        [InlineData(Squares.F5, null)]
        [InlineData(Squares.G5, null)]
        [InlineData(Squares.H5, null)]

        [InlineData(Squares.A6, null)]
        [InlineData(Squares.B6, null)]
        [InlineData(Squares.C6, null)]
        [InlineData(Squares.D6, null)]
        [InlineData(Squares.E6, null)]
        [InlineData(Squares.F6, null)]
        [InlineData(Squares.G6, null)]
        [InlineData(Squares.H6, null)]

        [InlineData(Squares.A7, Pawn.Name)]
        [InlineData(Squares.B7, Pawn.Name)]
        [InlineData(Squares.C7, Pawn.Name)]
        [InlineData(Squares.D7, Pawn.Name)]
        [InlineData(Squares.E7, Pawn.Name)]
        [InlineData(Squares.F7, Pawn.Name)]
        [InlineData(Squares.G7, Pawn.Name)]
        [InlineData(Squares.H7, Pawn.Name)]

        [InlineData(Squares.A8, Rook.Name)]
        [InlineData(Squares.B8, Knight.Name)]
        [InlineData(Squares.C8, Bishop.Name)]
        [InlineData(Squares.D8, Queen.Name)]
        [InlineData(Squares.E8, King.Name)]
        [InlineData(Squares.F8, Bishop.Name)]
        [InlineData(Squares.G8, Knight.Name)]
        [InlineData(Squares.H8, Rook.Name)]
        public void Can_Create_Board(string square, string piece)
        {
            Assert.Equal(piece, board.GetSquare(square)?.GetName());
        }

        [Theory]
        [InlineData(Knight.Name, Squares.B1, Squares.C3)]
        [InlineData(Knight.Name, Squares.B1, Squares.A3)]
        [InlineData(Bishop.Name, Squares.C1, Squares.D2)]
        [InlineData(Bishop.Name, Squares.C1, Squares.E3)]
        [InlineData(Bishop.Name, Squares.C1, Squares.F4)]
        [InlineData(Bishop.Name, Squares.C1, Squares.G5)]
        [InlineData(Bishop.Name, Squares.C1, Squares.H6)]
        public void Can_Move_Piece(string pieceName, string squareFrom, string squareTo)
        {
            //Move the piece
            Assert.True(board.TryMovePiece(squareFrom, squareTo));
            
            //Make sure target square has the knight now, and original square is null
            Assert.Null(board.GetSquare(squareFrom));
            Assert.Equal(pieceName, board.GetSquare(squareTo).GetName());
        }

        [Theory]
        [InlineData(Knight.Name, Squares.B1, Squares.B2)]
        [InlineData(Bishop.Name, Squares.C1, Squares.C2)]
        [InlineData(Bishop.Name, Squares.C1, Squares.E4)]
        public void Cannot_Move_Piece_To_Illegal_Square(string pieceName, string squareFrom, string squareTo)
        {
            Assert.False(board.TryMovePiece(squareFrom, squareTo));
            Assert.Equal(pieceName, board.GetSquare(squareFrom).GetName());
        }
    }
}
