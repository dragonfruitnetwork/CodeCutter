// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the Mozilla Public License Version 2.0. See the license.md file at the root of this repo for more info

using System;
using DragonFruit.Common.Data;

namespace DragonFruit.CodeCutter.Helpers
{
    internal class ReSharperToolsDownloadRequest : ApiFileRequest
    {
        public override string Path => "https://download-cf.jetbrains.com/resharper/dotUltimate.2020.2.4/JetBrains.ReSharper.CommandLineTools.2020.2.4.zip";

        public override string Destination => System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetFileName(new Uri(Path).LocalPath));
    }
}
