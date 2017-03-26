using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ObamaWantsChange.model
                          
{
	public class SingleCampaign
	{
		static public int id_Increment;

	[XmlAttribute]
	public int id { get; set; }

	[XmlAttribute]
	public DateTime date { get; set; }

	[XmlAttribute]
	public Boolean active { get; set; }

	[XmlAttribute]
	public String name { get; set; }

	[XmlAttribute]
	public String description { get; set; }

	[XmlElement]
	public List<SingleProduct> Products { get; set; }


		public SingleCampaign()
		{
			id_Increment++;
			this.id = id_Increment;
			this.Products = new List<SingleProduct>();
			this.active = true;

		}

		public void Die(){
			this.active = false;
		}

		public void Activate()
		{
			this.active = true;
		}
	}
}
