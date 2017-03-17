using System;
using System.Xml.Serialization;

namespace ObamaWantsChange.model
                          
{
	public class SingleCampaign

	[XmlAttribute]
	public int id { get; set; }

	[XmlAttribute]
	public Boolean active { get; set; }

	[XmlAttribute]
	public String description { get; set; }

	[XmlElement]
	public List<SingleProduct> Products { get; set; }

	{
		public SingleCampaign()
		{

				// tego nie czaje. skoro definiuje to jako zmienna to co to jest, instancja? 
			// czym sie rozni zdefiniowanie tego jako public... a new ...

			this.Products = new List<SingleProduct>();

		}
	}
}
