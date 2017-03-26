using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ObamaWantsChange.model
{
	public class SingleProduct

	{

		static public int id_Increment;

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
			//this.id = 1;
			//this.name = "djdjdj";

			this.Fixes = new List<SingleFix>();
			this.active = true;
		}

		//public SingleProduct(int id, Boolean active, String name)
		//{
			//this.id = id;
			//this.active = active;
			//this.name = name;
		//}

		public void Die()
		{
			this.active = false;
		}

		public void Activate()
		{
			this.active = true;
		}



	}
}
