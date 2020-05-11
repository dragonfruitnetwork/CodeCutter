// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the Mozilla Public License Version 2.0. See the license.md file at the root of this repo for more info

using System.Xml.Serialization;

namespace DragonFruit.CodeCutter.Inspector.Issues
{
    [XmlRoot(ElementName = "IssueType")]
    public class IssueType
    {
        [XmlAttribute(AttributeName = "Category")]
        public string Category { get; set; }

        [XmlAttribute(AttributeName = "CategoryId")]
        public string CategoryId { get; set; }

        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }

        [XmlAttribute(AttributeName = "Global")]
        public string Global { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "Severity")]
        public Severity Severity { get; set; }

        [XmlAttribute(AttributeName = "SubCategory")]
        public string SubCategory { get; set; }

        [XmlAttribute(AttributeName = "WikiUrl")]
        public string WikiUrl { get; set; }
    }
}
