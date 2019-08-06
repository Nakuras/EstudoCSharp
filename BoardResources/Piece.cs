﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessUdemy.BoardResources
{
    public class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int moviments { get; set; }
        public Board board { get; set; }

        public Piece(Position position, Color color, Board board)
        {
            this.position = position;
            this.color = color;
            this.board = board;
            moviments = 0;
        }
    }
}