using Engine;
using Engine.Pieces;
using KellermanSoftware.CompareNetObjects;
using NUnit.Framework;
using System;

namespace EngineTest
{
    public class IntegrationTest
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
        public void Single_Piece_On_Board_Has_Correct_Possible_Moves(Type pieceType, string startingSquare, string expectedPossibleMoves)
        {
            var board = new Board();
            IPiece piece = (IPiece)Activator.CreateInstance(pieceType);

            piece.AddToBoard(board, startingSquare);
            var actualPossibleMoves = board.GetPossibleMoves(startingSquare);

            var comparer = new CompareLogic(new ComparisonConfig() { IgnoreCollectionOrder = true });
            var result = comparer.Compare(expectedPossibleMoves.Split(','), actualPossibleMoves.ToArray());

            Assert.That(result.AreEqual, Is.True, result.DifferencesString);
        }

        [Test]
        [TestCase(typeof(Pawn), typeof(Pawn), Squares.E4, Squares.E5, "")]
        [TestCase(typeof(King), typeof(Pawn), Squares.E4, Squares.E5, "D4,D5,F5,F4,F3,E3,D3")]
        [TestCase(typeof(Bishop), typeof(Pawn), Squares.E4, Squares.D5, "C6,B7,A8,F3,G2,H1,F5,G6,H7,D3,C2,B1")]
        [TestCase(typeof(Rook), typeof(Pawn), Squares.E4, Squares.E5, "A4,B4,C4,D4,F4,G4,H4,E1,E2,E3,E6,E7,E8")]
        [TestCase(typeof(Knight), typeof(Pawn), Squares.E4, Squares.C5, "F6,G5,G3,F2,D2,C3,D6")]
        [TestCase(typeof(Queen), typeof(Pawn), Squares.E4, Squares.E5, "D5,C6,B7,A8,F3,G2,H1,F5,G6,H7,D3,C2,B1,A4,B4,C4,D4,F4,G4,H4,E1,E2,E3,E6,E7,E8")]
        public void Piece_Cannot_Move_To_Square_With_Another_Piece_Of_Same_Color(Type piece1Type, Type piece2Type, string square1, string square2, string expectedPossibleMoves)
        {
            var board = new Board();
            var piece1 = (IPiece)Activator.CreateInstance(piece1Type);
            var piece2 = (IPiece)Activator.CreateInstance(piece2Type);
            piece1.AddToBoard(board, square1);
            piece2.AddToBoard(board, square2);
            var expectedPossibleMovesSplit = expectedPossibleMoves == "" ? 
                new string[0] : expectedPossibleMoves.Split(',');

            var possibleMoves = board.GetPossibleMoves(piece1.CurrentSquare);

            var compareLogic = new CompareLogic(new ComparisonConfig() { IgnoreCollectionOrder = true });
            var result = compareLogic.Compare(expectedPossibleMovesSplit, possibleMoves.ToArray());
            Assert.That(result.AreEqual, Is.True, result.DifferencesString);
        }
    }
}