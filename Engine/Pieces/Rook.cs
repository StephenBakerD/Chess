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
            var x = Utilities.GetOridinal(CurrentSquare);
            var y = Utilities.GetOridinal(toSquare);

            //Calculate relative position deltas
            var deltaUp = Math.Abs(x.Row - y.Row);
            var deltaRight = Math.Abs(x.Column - y.Column);

            return ((deltaRight == 0 && deltaUp > 0) || (deltaRight > 0 && deltaUp == 0));
        }
    }
}
