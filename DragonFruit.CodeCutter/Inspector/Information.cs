// CodeCutter Copyright 2020 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the BSD 3-Clause "New" or "Revised" License. See the license.md file at the root of this repo for more info

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
