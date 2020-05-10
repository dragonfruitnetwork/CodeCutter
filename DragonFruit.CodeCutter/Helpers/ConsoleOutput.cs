using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonFruit.CodeCutter.Helpers
{
    public static class ConsoleOutput
    {
        public static void Print(string text) => Console.WriteLine(text);

        public static void Print(string text, ConsoleColor colour)
        {
            using (new ConsoleColour(colour))
            {
                Console.WriteLine(text);
            }
        }
    }
}
