using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Pieces
{
    public class Knight : IPiece
    {
        private Board board;

        public const string Name = "Knight";

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
            var deltaUp = Math.Abs(x.Row - y.Row); //Row 6 - Row 4 = 2 squares
            var deltaRight = Math.Abs(x.Column - y.Column); //Column F - Column E = 1 square

            return ((deltaUp == 2 && deltaRight == 1) || (deltaUp == 1 && deltaRight == 2));
        }
    }
}
