using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsole
{
    internal static class BounceVerbose
    {
        internal static void Execute()
        {
            // Initialize x, y coordinates to 0
            int x = 0;
            int y = 0;

            // Initialize velocity x, y to 1
            int velX = 1;
            int velY = 1;

            while (true)
            {
                // Add velocity to x, y coordinates
                x += velX;
                y += velY;

                // Check if we are at the right edge of console. Reverse velocity x if we are
                if (x == Console.WindowWidth - 1)
                {
                    velX = -1;
                }

                // Check if we are at the left edge of console. Reverse velocity x
                if (x == 0)
                {
                    velX = 1;
                }

                // Check if we are at the bottom edge of console. Reverse velocity y if we are
                if (y == Console.WindowHeight)
                {
                    velY = -1;
                }

                // Check if we are at top edge of console. Reverse velocity y
                if (y == 0)
                {
                    velY = 1;
                }

                // Clear console and print symbol at x, y coordinates
                Console.Clear();
                PrintAt(x, y, 'x');

                // Sleep thread for 30 milliseconds
                System.Threading.Thread.Sleep(30);
            }
        }

        internal static void PrintAt(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
