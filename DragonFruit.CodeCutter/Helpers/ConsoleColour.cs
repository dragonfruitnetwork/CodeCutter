// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the Mozilla Public License Version 2.0. See the license.md file at the root of this repo for more info

using System;

namespace DragonFruit.CodeCutter.Helpers
{
    public class ConsoleColour : IDisposable
    {
        private readonly ConsoleColor _previous;

        /// <summary>
        /// Sets the console colour at the start of the using statement, to be reverted at the end.
        /// </summary>
        /// <param name="colour">The colour to change to</param>
        public ConsoleColour(ConsoleColor colour)
        {
            _previous = Console.ForegroundColor;
            Console.ForegroundColor = colour;
        }

        /// <summary>
        /// Resets the console text colour at the end of the using statement
        /// </summary>
        public void Dispose()
        {
            Console.ForegroundColor = _previous;
        }
    }
}
