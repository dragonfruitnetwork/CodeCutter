// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the BSD 3-Clause "New" or "Revised" License. See the license.md file at the root of this repo for more info

using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using DragonFruit.CodeCutter.Helpers;
using DragonFruit.CodeCutter.Inspector;
using DragonFruit.CodeCutter.Objects;
using DragonFruit.Common.Data;

namespace DragonFruit.CodeCutter
{
    internal class Program 
    {
        private static readonly string BaseDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location ?? throw new EntryPointNotFoundException());
        private static readonly string AnalysisOutputFile = $"InspectCode-Output-{Guid.NewGuid().ToString().Split('-')[0]}.xml";

        private static string AnalysisFile => Path.Combine(Path.GetTempPath(), AnalysisOutputFile);

        private static string ReSharperTools => Path.Combine(Path.GetTempPath(), "ReSharper-Tools");
        private static string InspectCodeTool => Path.Combine(ReSharperTools, Environment.Is64BitOperatingSystem ? "inspectcode.exe" : "inspectcode.x86.exe");

        private static readonly Lazy<ApiClient> ServiceClient = new Lazy<ApiClient>();

        private static ConsoleColor SeverityColors(Severity issueSeverity)
        {
            switch (issueSeverity)
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

        private static void Main(string[] args)
        {
            var solutionName = args.Length > 0 ? args[0] : string.Empty;
            var minimumErrorLevel = args.Length > 1 ? (Severity)int.Parse(args[1]) : Severity.Error;
            var minimumDisplayLevel = args.Length > 2 ? (Severity) int.Parse(args[1]) : Severity.Warning;

            if (string.IsNullOrEmpty(solutionName))
            {
                ConsoleOutput.Print("No Solution Specified. Searching for a solution file...", ConsoleColor.Red);

                var searchResults = Directory.GetFiles(BaseDirectory, "*.sln", SearchOption.TopDirectoryOnly);
                if (searchResults.Any())
                {
                    solutionName = searchResults.First();
                }
                else
                {
                    ConsoleOutput.Print("Unable to find a solution file. Exiting...", ConsoleColor.Red);
                    Environment.Exit(-1);
                }
            }

            ConsoleOutput.Print($"Using solution file {Path.GetFileName(solutionName)} for analysis...\n", ConsoleColor.Green);

            if (!File.Exists(InspectCodeTool))
            {
                var request = new ReSharperToolsDownloadRequest();
                ConsoleOutput.Print($"JetBrains InspectTool Missing. Downloading from {request.Path}\n", ConsoleColor.DarkGray);

                ServiceClient.Value.Perform(request);
                
                if(Directory.Exists(ReSharperTools))
                {
                    Directory.Delete(ReSharperTools, true);
                }

                Directory.CreateDirectory(ReSharperTools);

                ConsoleOutput.Print("Extracting Tools.", ConsoleColor.DarkGreen);
                ZipFile.ExtractToDirectory(request.Destination, ReSharperTools);
            }

            ConsoleOutput.Print("\nStarting InspectTool Process...", ConsoleColor.Cyan);

            using (new ConsoleColour(ConsoleColor.DarkGray))
            using (var inspectCodeProcess = new Process())
            {
                inspectCodeProcess.StartInfo = new ProcessStartInfo
                {
                    FileName = InspectCodeTool,
                    Arguments = $"{solutionName} -o={AnalysisFile}",

                    UseShellExecute = false
                };

                inspectCodeProcess.Start();
                inspectCodeProcess.WaitForExit();
            }

            ConsoleOutput.Print("\nInspectCode Tool Finished Running.", ConsoleColor.Cyan);

            Report report;
            using (var reader = new StringReader(File.ReadAllText(AnalysisFile)))
            {
                var serializer = new XmlSerializer(typeof(Report));
                report = (Report)serializer.Deserialize(reader);
            }

            var anyIssues = false;
            var issueTypes = report.IssueTypes.IssueType.ToDictionary(x => x.Id, x => x);
            
            foreach (var project in report.Issues.Project)
            {
                var issues = project.Issues.Select(x => new CodeIssue(issueTypes[x.TypeId], x))
                    .Where(x => x.Severity >= minimumDisplayLevel)
                    .OrderByDescending(x => x.Severity);

                ConsoleOutput.Print($"\nProject: {project.Name} · {issues.Count()} Issues\n", ConsoleColor.Cyan);

                if (!issues.Any())
                    continue;

                anyIssues |= issues.Any(x => x.Severity >= minimumErrorLevel);

                foreach (var issueCategory in issues.GroupBy(x => x.Category))
                {
                    ConsoleOutput.Print(issueCategory.Key, SeverityColors(issueCategory.First().Severity));
                    Console.Write("\n");

                    foreach (var file in issueCategory.GroupBy(x => x.File))
                    {
                        ConsoleOutput.Print(file.Key, ConsoleColor.Magenta);

                        foreach (var issue in issueCategory)
                        {
                            ConsoleOutput.Print($"-> {issue.Message} (Line #{issue.Line})", ConsoleColor.DarkGray);
                        }

                        Console.Write("\n");
                    }

                    Console.Write("\n");
                }
            }

            Environment.Exit(anyIssues ? -1 : 0);
        }
    }
}
