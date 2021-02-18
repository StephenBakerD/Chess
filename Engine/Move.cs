using Engine;
using System;

namespace Engine
{
    public class Move
    {
        private static (int up, int right) CalculateRelativeDeltas(string fromSquare, string toSquare)
        {
            var x = Utilities.GetOridinal(fromSquare);
            var y = Utilities.GetOridinal(toSquare);

            var deltaUp = Math.Abs(x.Row - y.Row);
            var deltaRight = Math.Abs(x.Column - y.Column);

            return (deltaUp, deltaRight);
        }

        public static bool IsHorizontalMove(string fromSquare, string toSquare)
        {
            var delta = CalculateRelativeDeltas(fromSquare, toSquare);

            return delta.right > 0 && delta.up == 0;
        }

        public static bool IsVerticalMove(string fromSquare, string toSquare)
        {
            var delta = CalculateRelativeDeltas(fromSquare, toSquare);

            return delta.right == 0 && delta.up > 0;
        }

        public static bool IsDiagonalMove(string fromSquare, string toSquare)
        {
            var delta = CalculateRelativeDeltas(fromSquare, toSquare);

            return (delta.up > 0 && delta.right > 0 && delta.up % delta.right == 0 && delta.right % delta.up == 0);
        }

        public static bool IsLShapeMove(string fromSquare, string toSquare)
        {
            var delta = CalculateRelativeDeltas(fromSquare, toSquare);

            return ((delta.up == 2 && delta.right == 1) || (delta.up == 1 && delta.right == 2));
        }
    }
}