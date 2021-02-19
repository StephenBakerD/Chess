using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Pieces
{
    public class Bishop : IPiece
    {
        private Board board;

        public const string Name = "Bishop";

        public string CurrentSquare { get; private set; }

        public string GetName() => Name;

        public void AddToBoard(Board board, string square)
        {
            this.board = board;
            CurrentSquare = square;
            board.Squares[square] = this;
        }

        public bool TryMove(string toSquare)
        {
            return Move.IsDiagonal(CurrentSquare, toSquare);
        }
    }
}
