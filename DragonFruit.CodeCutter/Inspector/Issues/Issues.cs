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
