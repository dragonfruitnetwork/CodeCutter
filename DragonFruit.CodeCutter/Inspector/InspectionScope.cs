using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
