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
            ChessPosition chessPosition = new ChessPosition('c', 7);

            Console.WriteLine(chessPosition);

            Console.ReadLine();
        }
    }
}
