using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Pieces
{
    public class Bishop : IPiece
    {
        public const string Name = "Bishop";

        public string GetName() => Name;

        public bool TryMove(string squareFrom, string squareTo, IPiece targetPiece)
        {
            var x = Utilities.GetOridinal(squareFrom);
            var y = Utilities.GetOridinal(squareTo);

            //Calculate relative position deltas
            var deltaUp = Math.Abs(x.Row - y.Row);
            var deltaRight = Math.Abs(x.Column - y.Column);

            return (deltaUp > 0 && deltaRight > 0 && deltaUp % deltaRight == 0 && deltaRight % deltaUp == 0);
        }
    }
}
