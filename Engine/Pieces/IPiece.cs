using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public interface IPiece
    {
        string CurrentSquare { get; }
        bool TryMove(string square);
        string GetName();
        void AddToBoard(Board board, string square);
    }
}
