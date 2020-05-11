// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the Mozilla Public License Version 2.0. See the license.md file at the root of this repo for more info

using System.Diagnostics.CodeAnalysis;

namespace DragonFruit.CodeCutter.Inspector
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum Severity
    {
        Hint = 0,
        Suggestion = 1,
        Warning = 2,
        Error = 3,
        None = 4,

        //these are for XML Converting
        HINT = Hint,
        SUGGESTION = Suggestion,
        WARNING = Warning,
        ERROR = Error
    }
}