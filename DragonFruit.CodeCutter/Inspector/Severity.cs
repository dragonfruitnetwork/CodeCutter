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