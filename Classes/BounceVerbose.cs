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
            int x = 0;
            int y = 0;

            int velX = 1;
            int velY = 1;

            while (true)
            {
                x += velX;
                y += velY;

                if (x == Console.WindowWidth - 1)
                {
                    velX = -1;
                }

                if (x == 0)
                {
                    velX = 1;
                }

                if (y == Console.WindowHeight)
                {
                    velY = -1;
                }

                if (y == 0)
                {
                    velY = 1;
                }

                Console.Clear();
                PrintAt(x, y, 'x');

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
