using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ObamaWantsChange.model
{
	public class SingleProduct

	{

	[XmlAttribute]
	public int id { get; set; }

	[XmlAttribute]
	public Boolean active { get; set; }

	[XmlAttribute]
	public String name { get; set; }

	[XmlAttribute]
	public String description { get; set; }

	[XmlElement]
	public List<SingleFix> Fixes { get; set; }


	
		public SingleProduct()
		{

			// tego nie czaje. skoro definiuje to jako zmienna to co to jest, instancja? 
			// czym sie rozni zdefiniowanie tego jako public... a new ...

		this.Fixes = new List<SingleFix>();
		}
	}
}
