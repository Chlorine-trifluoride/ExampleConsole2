using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsole
{
    internal static class InfiniteReply
    {
        internal static void Execute()
        {
            while (true)
            {
                string input = Console.ReadLine();
                Console.WriteLine(input);
            }
        }
    }
}
