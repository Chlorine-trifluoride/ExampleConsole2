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
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;

            PrintAt(x, y, 'x');

            while (true)
            {
                char inputChar = Console.ReadKey().KeyChar;

                if (inputChar == 'd')
                {
                    x = x + 1;
                }

                if (inputChar == 'w')
                {
                    y = y - 1;
                }

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
