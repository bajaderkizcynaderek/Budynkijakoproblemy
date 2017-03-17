using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ObamaWantsChange.model
                          
{
	public class SingleClient
	{

		[XmlAttribute]
		public int id { get; set; }

		[XmlAttribute]
		public String name { get; set; }

		[XmlAttribute]
		public String description { get; set; }

		[XmlElement]
		public List<SingleCampaign> Campaigns { get; set; }


		public SingleClient()
		{
			this.Campaigns = new List<SingleCampaign>();
		}
	}
}
