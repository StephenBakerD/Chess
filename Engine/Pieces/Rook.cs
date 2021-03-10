using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Pieces
{
    public class Rook : IPiece
    {
        private Board board;

        public const string Name = "Rook";

        public string GetName() => Name;

        public string CurrentSquare { get; private set; }

        public Dictionary<string, IPiece> Board { get; private set; }

        public void AddToBoard(Board board, string square)
        {
            this.board = board;
            CurrentSquare = square;
            board.Squares[square] = this;
        }

        public bool TryMove(string toSquare)
        {
            var isPieceOnDestination = board.Squares[toSquare] != null;
            var isHorizontal = Move.IsHorizontal(CurrentSquare, toSquare);
            var isVertical = Move.IsVertical(CurrentSquare, toSquare);

            return (isHorizontal || isVertical) && !isPieceOnDestination;
        }
    }
}
