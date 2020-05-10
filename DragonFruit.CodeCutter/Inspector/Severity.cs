// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the BSD 3-Clause "New" or "Revised" License. See the license.md file at the root of this repo for more info

using System.Diagnostics.CodeAnalysis;

namespace DragonFruit.CodeCutter.Inspector
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum Severity
    {
        Hint,
        Suggestion,
        Warning,
        Error,

        HINT = Hint,
        SUGGESTION = Suggestion,
        WARNING = Warning,
        ERROR = Error
    }
}