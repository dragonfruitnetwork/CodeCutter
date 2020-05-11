// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the Mozilla Public License Version 2.0. See the license.md file at the root of this repo for more info

using DragonFruit.CodeCutter.Inspector;
using Newtonsoft.Json;

namespace DragonFruit.CodeCutter.Objects
{
    internal class AppConfig
    {
        [JsonProperty("solution")]
        public string SolutionFile { get; set; }

        [JsonProperty("displayLevel")]
        public Severity DisplayLevel { get; set; } = Severity.Warning;

        [JsonProperty("errorLevel")]
        public Severity ErrorLevel { get; set; } = Severity.Error;
    }
}
