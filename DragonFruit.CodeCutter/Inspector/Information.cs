using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DragonFruit.CodeCutter.Inspector
{
	[XmlRoot(ElementName = "Information")]
	public class Information
	{
		[XmlElement(ElementName = "InspectionScope")]
		public InspectionScope InspectionScope { get; set; }

		[XmlElement(ElementName = "Solution")]
		public string Solution { get; set; }
	}
}
