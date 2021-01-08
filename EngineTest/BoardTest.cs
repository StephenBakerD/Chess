using Engine;
using Xunit;
using System;

namespace EngineTest
{
    public class BoardTest
    {
        [Theory]
        [InlineData(Squares.A1, Pieces.Rook)]
        [InlineData(Squares.B1, Pieces.Knight)]
        [InlineData(Squares.C1, Pieces.Bishop)]
        [InlineData(Squares.D1, Pieces.Queen)]
        [InlineData(Squares.E1, Pieces.King)]
        [InlineData(Squares.F1, Pieces.Bishop)]
        [InlineData(Squares.G1, Pieces.Knight)]
        [InlineData(Squares.H1, Pieces.Rook)]

        [InlineData(Squares.A2, Pieces.Pawn)]
        [InlineData(Squares.B2, Pieces.Pawn)]
        [InlineData(Squares.C2, Pieces.Pawn)]
        [InlineData(Squares.D2, Pieces.Pawn)]
        [InlineData(Squares.E2, Pieces.Pawn)]
        [InlineData(Squares.F2, Pieces.Pawn)]
        [InlineData(Squares.G2, Pieces.Pawn)]
        [InlineData(Squares.H2, Pieces.Pawn)]

        [InlineData(Squares.A3, Pieces.Empty)]
        [InlineData(Squares.B3, Pieces.Empty)]
        [InlineData(Squares.C3, Pieces.Empty)]
        [InlineData(Squares.D3, Pieces.Empty)]
        [InlineData(Squares.E3, Pieces.Empty)]
        [InlineData(Squares.F3, Pieces.Empty)]
        [InlineData(Squares.G3, Pieces.Empty)]
        [InlineData(Squares.H3, Pieces.Empty)]

        [InlineData(Squares.A4, Pieces.Empty)]
        [InlineData(Squares.B4, Pieces.Empty)]
        [InlineData(Squares.C4, Pieces.Empty)]
        [InlineData(Squares.D4, Pieces.Empty)]
        [InlineData(Squares.E4, Pieces.Empty)]
        [InlineData(Squares.F4, Pieces.Empty)]
        [InlineData(Squares.G4, Pieces.Empty)]
        [InlineData(Squares.H4, Pieces.Empty)]

        [InlineData(Squares.A5, Pieces.Empty)]
        [InlineData(Squares.B5, Pieces.Empty)]
        [InlineData(Squares.C5, Pieces.Empty)]
        [InlineData(Squares.D5, Pieces.Empty)]
        [InlineData(Squares.E5, Pieces.Empty)]
        [InlineData(Squares.F5, Pieces.Empty)]
        [InlineData(Squares.G5, Pieces.Empty)]
        [InlineData(Squares.H5, Pieces.Empty)]

        [InlineData(Squares.A6, Pieces.Empty)]
        [InlineData(Squares.B6, Pieces.Empty)]
        [InlineData(Squares.C6, Pieces.Empty)]
        [InlineData(Squares.D6, Pieces.Empty)]
        [InlineData(Squares.E6, Pieces.Empty)]
        [InlineData(Squares.F6, Pieces.Empty)]
        [InlineData(Squares.G6, Pieces.Empty)]
        [InlineData(Squares.H6, Pieces.Empty)]

        [InlineData(Squares.A7, Pieces.Pawn)]
        [InlineData(Squares.B7, Pieces.Pawn)]
        [InlineData(Squares.C7, Pieces.Pawn)]
        [InlineData(Squares.D7, Pieces.Pawn)]
        [InlineData(Squares.E7, Pieces.Pawn)]
        [InlineData(Squares.F7, Pieces.Pawn)]
        [InlineData(Squares.G7, Pieces.Pawn)]
        [InlineData(Squares.H7, Pieces.Pawn)]

        [InlineData(Squares.A8, Pieces.Rook)]
        [InlineData(Squares.B8, Pieces.Knight)]
        [InlineData(Squares.C8, Pieces.Bishop)]
        [InlineData(Squares.D8, Pieces.Queen)]
        [InlineData(Squares.E8, Pieces.King)]
        [InlineData(Squares.F8, Pieces.Bishop)]
        [InlineData(Squares.G8, Pieces.Knight)]
        [InlineData(Squares.H8, Pieces.Rook)]
        public void Can_Create_Board(string square, string piece)
        {
            var board = new Board();

            Assert.Equal(piece, board.GetSquare(square));
        }

        [Theory]
        [InlineData(Squares.B1, Squares.C3)]
        [InlineData(Squares.B1, Squares.A3)]
        public void Can_Move_Knight(string squareFrom, string squareTo)
        {
            var board = new Board();

            //Make sure target square is empty, and knight is on original square
            Assert.Equal(Pieces.Knight, board.GetSquare(squareFrom));
            Assert.Equal(Pieces.Empty, board.GetSquare(squareTo));

            //Move the piece
            board.MovePiece(squareFrom, squareTo);

            //Make sure target square has the knight now, and original square is empty
            Assert.Equal(Pieces.Empty, board.GetSquare(squareFrom));
            Assert.Equal(Pieces.Knight, board.GetSquare(squareTo));
        }

        [Theory]
        [InlineData(Squares.C1, Squares.D2)]
        [InlineData(Squares.C1, Squares.E3)]
        [InlineData(Squares.C1, Squares.F4)]
        [InlineData(Squares.C1, Squares.G5)]
        [InlineData(Squares.C1, Squares.H6)]
        public void Can_Move_Bishop(string squareFrom, string squareTo)
        {
            var board = new Board();

            //Make sure piece is on original square
            Assert.Equal(Pieces.Bishop, board.GetSquare(squareFrom));

            //Move the piece
            board.MovePiece(squareFrom, squareTo);

            //Make sure target square has the piece now, and original square is empty
            Assert.Equal(Pieces.Empty, board.GetSquare(squareFrom));
            Assert.Equal(Pieces.Bishop, board.GetSquare(squareTo));
        }

        [Theory]
        [InlineData(Squares.B1, Squares.B2)]
        public void Cannot_Move_Knight_To_Illegal_Square(string squareFrom, string squareTo)
        {
            var board = new Board();

            Assert.Throws<InvalidOperationException>(() =>
            {
                board.MovePiece(squareFrom, squareTo); //Invalid move
            });
        }

        [Theory]
        [InlineData(Squares.C1, Squares.C2)]
        [InlineData(Squares.C1, Squares.E4)]
        public void Cannot_Move_Bishop_To_Illegal_Square(string squareFrom, string squareTo)
        {
            var board = new Board();

            Assert.Throws<InvalidOperationException>(() =>
            {
                board.MovePiece(squareFrom, squareTo); //Invalid move
            });
        }
    }
}
