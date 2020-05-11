// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the Mozilla Public License Version 2.0. See the license.md file at the root of this repo for more info

using System;
using DragonFruit.CodeCutter.Inspector;
using DragonFruit.CodeCutter.Inspector.Issues;

namespace DragonFruit.CodeCutter.Objects
{
    public class CodeIssue
    {
        public CodeIssue(IssueType type, Issue issue)
        {
            Severity = type.Severity;
            Category = type.Category;

            File = issue.File;
            Line = issue.Line;
            Message = issue.Message;
        }

        public Severity Severity { get; set; }

        public string Category { get; set; }
        
        public string File { get; set; }

        public uint Line { get; set; }

        public string Message { get; set; }

        public ConsoleColor SeverityColor
        {
            get
            {
                switch (Severity)
                {
                    case Severity.Error:
                        return ConsoleColor.Red;

                    case Severity.Warning:
                        return ConsoleColor.Yellow;

                    case Severity.Suggestion:
                        return ConsoleColor.DarkCyan;

                    case Severity.Hint:
                        return ConsoleColor.DarkGray;

                    default:
                        return ConsoleColor.Gray;
                }
            }
        }
    }
}
