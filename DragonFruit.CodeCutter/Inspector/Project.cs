// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the BSD 3-Clause "New" or "Revised" License. See the license.md file at the root of this repo for more info

using System.Collections.Generic;
using System.Xml.Serialization;
using DragonFruit.CodeCutter.Inspector.Issues;

namespace DragonFruit.CodeCutter.Inspector
{
    [XmlRoot(ElementName = "Project")]
    public class Project
    {
        [XmlElement(ElementName = "Issue")]
        public List<Issue> Issues { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }
}
