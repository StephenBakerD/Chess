﻿
using System;
using System.Collections.Generic;
using System.Text;
using Engine;

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
            var isPieceOnDestination = board.Squares[toSquare] != null;
            var isLShape = Move.IsLShape(CurrentSquare, toSquare);

            return isLShape && !isPieceOnDestination;
        }
    }
}
