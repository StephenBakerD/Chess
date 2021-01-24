using Engine;
using Engine.Pieces;
using Xunit;
using System;
using System.Collections.Generic;

namespace EngineTest
{
    public class BoardTest
    {
        [Fact]
        public void Can_Create_Normal_Board()
        {
            var board = new Board(Board.NormalPieceArrangement);
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
            var board = new Board(Board.NormalPieceArrangement);

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
            var board = new Board(Board.NormalPieceArrangement);

            Assert.False(board.TryMovePiece(squareFrom, squareTo));
            Assert.Equal(pieceName, board.GetSquare(squareFrom).GetName());
        }
    }
}
