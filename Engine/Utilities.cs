using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class Utilities
    {
        public static (int Column, int Row) GetOridinal(string square)
        {
            var column = square[0] - 64; //A in ASCII is 65
            var row = int.Parse(square[1].ToString());

            return ((int) column, row);
        }
    }
}
