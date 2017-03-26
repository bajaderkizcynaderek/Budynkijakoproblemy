using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ObamaWantsChange.model
{
	public class SingleFix
	{

		static public int id_Increment;

		[XmlAttribute]
		public int id { get; set; }

		[XmlAttribute]
		public DateTime date { get; set; }

		[XmlAttribute]
		public String imageUrl { get; set; }

		[XmlAttribute]
		public String description { get; set; }

		public SingleFix()
		// empty contructor is redundant
		{
			id_Increment++;
			this.id = id_Increment;
			this.date = DateTime.Now;

		}
		public SingleFix(String sentImage, String sentDescription)
		// empty contructor is redundant
		{
			id_Increment++;
			this.id = id_Increment;
			this.date = DateTime.Now;
			this.imageUrl = sentImage;
			this.description = sentDescription;

		}
	}
}
