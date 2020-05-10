using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
