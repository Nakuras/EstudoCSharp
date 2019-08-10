using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessUdemy.BoardResources;
using ChessUdemy.Chess;

namespace ChessUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessGame chessGame = new ChessGame();

                while (!chessGame.concluded)
                {
                    Console.Clear();
                    Screen.PrintBoard(chessGame.Board);

                    Console.WriteLine();
                    Console.WriteLine("Origin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();

                    Console.WriteLine("Destiny: ");
                    Position destiny = Screen.ReadChessPosition().ToPosition();

                    chessGame.Moviment(origin, destiny);
                }

            }
            catch (BoardException e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
