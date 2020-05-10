// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the BSD 3-Clause "New" or "Revised" License. See the license.md file at the root of this repo for more info

using System.Xml.Serialization;

namespace DragonFruit.CodeCutter.Inspector
{
    [XmlRoot(ElementName = "InspectionScope")]
    public class InspectionScope
    {
        [XmlElement(ElementName = "Element")]
        public string Element { get; set; }
    }
}
