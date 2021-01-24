using Engine;
using Engine.Pieces;
using Xunit;
using System;
using System.Collections.Generic;
using KellermanSoftware.CompareNetObjects;
using System.Linq;

namespace EngineTest
{
    public class BoardTest
    {
        [Theory]
        [InlineData(Bishop.Name, Squares.E4, "D5", "C6", "B7", "A8", "F3", "G2", "H1", "F5", "G6", "H7", "D3", "C2", "B1")]
        public void Can_Move_Piece(string pieceName, string fromSquare, params string[] expectedSquares)
        {
            var board = new Board();
            var piece = new Bishop();
            piece.AddToBoard(board, fromSquare);

            var actualSquares = board.GetPossibleMoves(fromSquare);

            var comparer = new CompareLogic(new ComparisonConfig() { IgnoreCollectionOrder = true });
            
            var result = comparer.Compare(expectedSquares.ToList(), actualSquares);

            Assert.True(result.AreEqual, result.DifferencesString);
        }

        //[Theory]
        //[InlineData(Knight.Name, Squares.B1, Squares.B2)]
        //[InlineData(Bishop.Name, Squares.C1, Squares.C2)]
        //[InlineData(Bishop.Name, Squares.C1, Squares.E4)]
        //public void Cannot_Move_Piece_To_Illegal_Square(string pieceName, string squareFrom, string squareTo)
        //{
        //    var board = new Board(Board.NormalPieceArrangement);

        //    Assert.False(board.TryMovePiece(squareFrom, squareTo));
        //    Assert.Equal(pieceName, board.GetPiece(squareFrom).GetName());
        //}
    }
}
