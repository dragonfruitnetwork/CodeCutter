// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the Mozilla Public License Version 2.0. See the license.md file at the root of this repo for more info

using System.Collections.Generic;
using System.Xml.Serialization;

namespace DragonFruit.CodeCutter.Inspector.Issues
{
    [XmlRoot(ElementName = "Issues")]
    public class Issues
    {
        [XmlElement(ElementName = "Project")]
        public List<Project> Project { get; set; }
    }
}
