using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
