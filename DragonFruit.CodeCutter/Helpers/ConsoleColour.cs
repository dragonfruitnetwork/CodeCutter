using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
