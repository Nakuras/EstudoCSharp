using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessUdemy.BoardResources
{
    public class Board
    {
        public int lines { get; set; }
        public int colums { get; set; }
        public Piece[,] pieces { get; set; }

        public Board(int lines, int colums)
        {
            this.lines = lines;
            this.colums = colums;
            pieces = new Piece[lines, colums];
        }
    }
}
