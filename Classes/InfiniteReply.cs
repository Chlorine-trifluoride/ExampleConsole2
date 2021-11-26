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
                // Wait for one line input from console and store in to input variable
                string input = Console.ReadLine();

                // Print out the input variable
                Console.WriteLine(input);
            }
        }
    }
}
