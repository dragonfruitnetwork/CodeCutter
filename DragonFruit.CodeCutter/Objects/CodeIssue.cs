using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
