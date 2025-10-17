using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

// 1. I asked Copilot how to create a ReadSize() method in a separate file without creating a new object, as well as not clogging my main.
// Copilot answered: To keep your code clean and modular, you can move the ReadSize() method into a static class in a separate file.
// In C#, a static class is ideal for grouping utility methods that don’t rely on instance data — like input validation or helper functions.
// I proceeded to write the code and put static after "public".
// This is the solution:

namespace Chessboard2
{
    public static class ReadSize
    {
        public static int ReadChessboardSize()
        {
            int chessboardSize;

            // Error handling
            while (true)
            {
                Console.WriteLine("Please input a number between 3 and 50. The number will determine the size of the chessboard");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out chessboardSize))
                {
                    Console.WriteLine("You must write a valid number, try again");
                    continue;
                }

                if (chessboardSize < 3 || chessboardSize > 50)
                {
                    Console.WriteLine("The number is outside the accepted interval, try again");
                    continue;
                }

                break;
            }

            return chessboardSize;
        }
    }
}


