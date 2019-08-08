using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessUdemy.BoardResources;

namespace ChessUdemy.Chess
{
    class ChessPosition
    {
        public char Colum { get; set; }
        public int Line { get; set; }

        public ChessPosition(char colum, int line)
        {
            Colum = colum;
            Line = line;
        }

        public Position ToPosition()
        {
            return new Position(8 - Line, Colum - 'a');
        }

        public override string ToString()
        {
            return "" + Colum + Line;
        }
    }
}
