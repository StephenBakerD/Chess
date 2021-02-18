using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Pieces
{
    public class Queen : IPiece
    {
        private Board board;

        public const string Name = "Queen";

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
            return Move.IsHorizontalMove(CurrentSquare, toSquare)
                || Move.IsVerticalMove(CurrentSquare, toSquare)
                || Move.IsDiagonalMove(CurrentSquare, toSquare);
        }
    }
}
