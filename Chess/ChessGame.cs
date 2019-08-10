using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessUdemy.BoardResources;

namespace ChessUdemy.Chess
{
    public class ChessGame
    {
        public Board Board { get; private set; }
        private int turn;
        private Color playerColor;
        public bool concluded { get; private set; }
        
        public ChessGame()
        {
            Board = new Board(8, 8);
            turn = 1;
            playerColor = Color.White;
            concluded = false;
            DefaultPiecesPosition();
        }

        public void Moviment(Position origin, Position destiny)
        {
            Piece piece = Board.RemovePiece(origin);
            piece.MovimentIncrease();
            Piece pieceCatched = Board.RemovePiece(destiny);
            Board.PutPiece(piece, destiny);
        }

        private void DefaultPiecesPosition()
        {
            Board.PutPiece(new Tower(Board, Color.White), new ChessPosition('c', 1).ToPosition());
            Board.PutPiece(new Tower(Board, Color.White), new ChessPosition('c', 2).ToPosition());
        }
    }
}
