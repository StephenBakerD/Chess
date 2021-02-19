using Engine;
using Engine.Pieces;
using KellermanSoftware.CompareNetObjects;
using NUnit.Framework;
using System;

namespace EngineTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(typeof(Bishop), Squares.E4, "D5,C6,B7,A8,F3,G2,H1,F5,G6,H7,D3,C2,B1")]
        [TestCase(typeof(Knight), Squares.E4, "F6,G5,G3,F2,D2,C3,C5,D6")]
        [TestCase(typeof(Rook), Squares.E4, "A4,B4,C4,D4,F4,G4,H4,E1,E2,E3,E5,E6,E7,E8")]
        [TestCase(typeof(Queen), Squares.E4, "D5,C6,B7,A8,F3,G2,H1,F5,G6,H7,D3,C2,B1,A4,B4,C4,D4,F4,G4,H4,E1,E2,E3,E5,E6,E7,E8")]
        [TestCase(typeof(Pawn), Squares.E4, "E5")]
        [TestCase(typeof(King), Squares.E4, "E5,F5,F4,F3,E3,D3,D4,D5")]
        public void Can_Move_Piece(Type pieceType, string startingSquare, string expectedPossibleMoves)
        {
            var board = new Board();
            IPiece piece = (IPiece)Activator.CreateInstance(pieceType);

            piece.AddToBoard(board, startingSquare);
            var actualPossibleMoves = board.GetPossibleMoves(startingSquare);

            var comparer = new CompareLogic(new ComparisonConfig() { IgnoreCollectionOrder = true });
            var result = comparer.Compare(expectedPossibleMoves.Split(','), actualPossibleMoves.ToArray());

            Assert.That(result.AreEqual, Is.True, result.DifferencesString);
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