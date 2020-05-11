// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the Mozilla Public License Version 2.0. See the license.md file at the root of this repo for more info

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
