using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RokuDataObjects
{
    public enum RokuAppIds
    {
        Netflix = 12,
        ESPN = 34376,
        Emby = 44191,
		Fandango = 31012
	}

	[XmlRoot(ElementName = "app")]
	public class RokuApp
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "version")]
		public string Version { get; set; }
		[XmlText]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "apps")]
	public class RokuApps
	{
		[XmlElement(ElementName = "app")]
		public List<RokuApp> App { get; set; }
	}
}
