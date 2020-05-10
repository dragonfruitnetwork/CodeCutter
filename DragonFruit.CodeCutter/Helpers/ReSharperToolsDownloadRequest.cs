using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using IO = System.IO;

namespace DragonFruit.CodeCutter.Helpers
{
    internal class ReSharperToolsDownloadRequest : ApiFileRequest
    {
        public override string Path => "https://download-cf.jetbrains.com/resharper/ReSharperUltimate.2020.1.2/JetBrains.ReSharper.CommandLineTools.2020.1.2.zip";

        public override string Destination => IO::Path.Combine(IO::Path.GetTempPath(), IO::Path.GetFileName(new Uri(Path).LocalPath));
    }
}
