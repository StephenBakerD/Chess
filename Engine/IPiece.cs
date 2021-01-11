using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public interface IPiece
    {
        bool TryMove(string squareFrom, string squareTo, IPiece targetPiece);
        string GetName();
    }
}
