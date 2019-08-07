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
        private Piece[,] pieces;

        public Board(int lines, int colums)
        {
            this.lines = lines;
            this.colums = colums;
            pieces = new Piece[lines, colums];
        }

        public Piece Piece(Position position)
        {
            return pieces[position.line, position.colum];
        }

        public Piece Piece(int line, int colum)
        {
            return pieces[line, colum];
        }

        public bool PieceExistence(Position position)
        {
            ValidatePosition(position);
            return Piece(position) != null;
        }

        public void PutPiece(Piece piece, Position position)
        {
            if (PieceExistence(position))
            {
                throw new BoardException("Exist a piece in this position!");
            }
            pieces[position.line, position.colum] = piece;
            piece.position = position;
        }

        public bool PositionValid(Position position)
        {
            if (position.line < 0 || position.colum < 0 ||
                position.line >= lines || position.colum >= colums)
            {
                return false;
            }

            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!PositionValid(position))
            {
                throw new BoardException("Invalid Position!");
            }
        }
    }
}
