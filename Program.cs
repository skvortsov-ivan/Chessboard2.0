// Comments that have an initial number are the ones corresponding to me asking AI a question, AI's suggested improvement and a solution.
// The numbers correspond to the chronological work order.
using System.Drawing;

namespace Chessboard2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 My Chessboard() method was printing ??? instead of the desired squares so Copilot suggested me to enable UTF-8 encoding and it worked.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Reading chessboard size
            int chessboardSize = ReadSize.ReadChessboardSize();
            Console.WriteLine($"Selected size: {chessboardSize}");

            // Printing Chessboard
            var board = new RenderBoard();
            board.Chessboard(chessboardSize);
        }
    }
}
