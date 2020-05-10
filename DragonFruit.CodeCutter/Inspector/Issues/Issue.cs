using System.Xml.Serialization;

namespace DragonFruit.CodeCutter.Inspector.Issues
{
    [XmlRoot(ElementName = "Issue")]
    public class Issue
    {
        [XmlAttribute(AttributeName = "File")]
        public string File { get; set; }

        [XmlAttribute(AttributeName = "Line")]
        public uint Line { get; set; }

        [XmlAttribute(AttributeName = "Message")]
        public string Message { get; set; }

        [XmlAttribute(AttributeName = "Offset")]
        public string Offset { get; set; }

        [XmlAttribute(AttributeName = "TypeId")]
        public string TypeId { get; set; }
    }
}
