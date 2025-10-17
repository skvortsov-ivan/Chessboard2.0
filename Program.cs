// Comments that have an initial number are the ones corresponding to me asking AI a question, AI's suggested improvement and a solution.
// The numbers correspond to the chronological work order.
namespace Chessboard2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reading chessboard size
            int chessboardSize = ReadSize.ReadChessboardSize();
            Console.WriteLine($"Selected size: {chessboardSize}");
        }
    }
}
