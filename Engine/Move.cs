using Engine;
using System;

namespace Engine
{
    public class Move
    {
        private static (int up, int right) CalculateDeltas(string fromSquare, string toSquare, bool absolute)
        {
            var from = Utilities.GetOridinal(fromSquare);
            var to = Utilities.GetOridinal(toSquare);

            var deltaUp = to.Row - from.Row;
            var deltaRight = to.Column - from.Column;

            if (absolute)
            {
                deltaUp = Math.Abs(deltaUp);
                deltaRight = Math.Abs(deltaRight);
            }

            return (deltaUp, deltaRight);
        }

        public static bool IsHorizontal(string fromSquare, string toSquare)
        {
            var delta = CalculateDeltas(fromSquare, toSquare, absolute: true);

            return delta.right > 0 && delta.up == 0;
        }

        public static bool IsVertical(string fromSquare, string toSquare)
        {
            var delta = CalculateDeltas(fromSquare, toSquare, absolute: true);

            return delta.right == 0 && delta.up > 0;
        }

        public static bool IsDiagonal(string fromSquare, string toSquare)
        {
            var delta = CalculateDeltas(fromSquare, toSquare, absolute: true);

            return (delta.up > 0 && delta.right > 0 && delta.up % delta.right == 0 && delta.right % delta.up == 0);
        }

        public static bool IsLShape(string fromSquare, string toSquare)
        {
            var delta = CalculateDeltas(fromSquare, toSquare, absolute: true);

            return ((delta.up == 2 && delta.right == 1) || (delta.up == 1 && delta.right == 2));
        }

        public static bool IsOneInFront(string fromSquare, string toSquare)
        {
            var delta = CalculateDeltas(fromSquare, toSquare, absolute: false);

            return (delta.up == 1 & delta.right == 0);
        }

        public static bool IsOne(string fromSquare, string toSquare)
        {
            var delta = CalculateDeltas(fromSquare, toSquare, absolute: true);

            bool isVertical = delta.up == 1 && delta.right == 0;
            bool isHorizontal = delta.up == 0 && delta.right == 1;
            bool isDiagonal = delta.up == 1 && delta.right == 1;

            return isVertical || isHorizontal || isDiagonal;
        }
    }
}