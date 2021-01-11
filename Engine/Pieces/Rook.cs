using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Pieces
{
    public class Rook : IPiece
    {
        public const string Name = "Rook";

        public string GetName() => Name;

        public bool TryMove(string squareFrom, string squareTo, IPiece targetPiece)
        {
            throw new NotImplementedException();
        }
    }
}
