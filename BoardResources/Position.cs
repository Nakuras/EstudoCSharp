using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessUdemy.BoardResources
{
    public class Position
    {
        public int line { get; set; }
        public int colum { get; set; }

        public Position(int line, int colum)
        {
            this.line = line;
            this.colum = colum;
        }

        public override string ToString()
        {
            return line
                + ", "
                + colum;
        }
    }
}
