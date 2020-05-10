// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the BSD 3-Clause "New" or "Revised" License. See the license.md file at the root of this repo for more info

using System;
using DragonFruit.Common.Data;

namespace DragonFruit.CodeCutter.Helpers
{
    internal class ReSharperToolsDownloadRequest : ApiFileRequest
    {
        public override string Path => "https://download-cf.jetbrains.com/resharper/ReSharperUltimate.2020.1.2/JetBrains.ReSharper.CommandLineTools.2020.1.2.zip";

        public override string Destination => System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetFileName(new Uri(Path).LocalPath));
    }
}
