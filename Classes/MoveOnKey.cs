using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsole
{
    internal static class MoveOnKey
    {
        internal static void Execute()
        {
            // Initialize coordinates to the center of the console
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;

            // Print first character before getting stuck on Console.Readkey()
            PrintAt(x, y, 'x');

            while (true)
            {
                // Read the first inputed character from console
                char inputChar = Console.ReadKey().KeyChar;

                // Add 1 to x if input is d
                if (inputChar == 'd')
                {
                    x = x + 1;
                }

                // Deduct 1 from y if input is w
                if (inputChar == 'w')
                {
                    y = y - 1;
                }

                // Clear console and print 'x' at new coordinates
                Console.Clear();
                PrintAt(x, y, 'x');
            }
        }

        internal static void PrintAt(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
