// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the Mozilla Public License Version 2.0. See the license.md file at the root of this repo for more info

using System.Xml.Serialization;
using DragonFruit.CodeCutter.Inspector.Issues;

namespace DragonFruit.CodeCutter.Inspector
{
    [XmlRoot(ElementName = "Report")]
    public class Report
    {
        [XmlElement(ElementName = "Information")]
        public Information Information { get; set; }

        [XmlElement(ElementName = "Issues")]
        public Issues.Issues Issues { get; set; }

        [XmlElement(ElementName = "IssueTypes")]
        public IssueTypes IssueTypes { get; set; }

        [XmlAttribute(AttributeName = "ToolsVersion")]
        public string ToolsVersion { get; set; }
    }
}
