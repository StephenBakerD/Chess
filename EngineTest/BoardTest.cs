using Engine;
using Xunit;

namespace EngineTest
{
    public class BoardTest
    {
        [Theory]
        [InlineData(Squares.A1, Pieces.Rook)]
        [InlineData(Squares.B1, Pieces.Knight)]
        [InlineData(Squares.C1, Pieces.Bishop)]
        //TODO: Add all pieces
        public void Can_Create_Board(string square, string piece)
        {
            var game = new Board();

            Assert.Equal(piece, game.GetSquare(square));
        }

        [Fact]
        public void Can_Move_Piece()
        {
            var board = new Board();

            Assert.Equal(Pieces.Knight, board.GetSquare("B1"));
            Assert.Equal(Pieces.Empty, board.GetSquare("C3"));

            board.MovePiece("B1", "C3");

            Assert.Equal(Pieces.Empty, board.GetSquare("B1"));
            Assert.Equal(Pieces.Knight, board.GetSquare("C3"));
        }
    }
}
