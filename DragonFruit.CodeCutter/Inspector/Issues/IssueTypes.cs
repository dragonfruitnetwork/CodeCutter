using System.Collections.Generic;
using System.Xml.Serialization;

namespace DragonFruit.CodeCutter.Inspector.Issues
{
    [XmlRoot(ElementName = "IssueTypes")]
    public class IssueTypes
    {
        [XmlElement(ElementName = "IssueType")]
        public List<IssueType> IssueType { get; set; }
    }
}
