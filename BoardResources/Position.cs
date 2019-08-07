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

        public Position(int linha, int coluna)
        {
            this.line = linha;
            this.colum = coluna;
        }

        public override string ToString()
        {
            return line
                + ", "
                + colum;
        }
    }
}
