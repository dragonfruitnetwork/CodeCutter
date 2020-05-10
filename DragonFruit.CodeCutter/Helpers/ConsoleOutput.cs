// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the BSD 3-Clause "New" or "Revised" License. See the license.md file at the root of this repo for more info

using System;

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
