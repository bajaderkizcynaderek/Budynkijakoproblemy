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

		//public String sentImage;
		//public String sentDescription;

		public SingleFix()

		{
			id_Increment++;
			this.id = id_Increment;
			DateTime tempDate = DateTime.Now;
			this.date = tempDate;

		}
		public SingleFix(String sentImage, String sentDescription)

		{
			id_Increment++;
			this.id = id_Increment;
			DateTime tempDate = DateTime.Now;
			this.date = tempDate;
			this.imageUrl = sentImage;
			this.description = sentDescription;

		}

		public void Add(String sentImage, String sentDescription)

		{
			id_Increment++;
			this.id = id_Increment;
			DateTime tempDate = DateTime.Now;
			this.date = tempDate;
			this.imageUrl = sentImage;
			this.description = sentDescription;

		}
		public void Add()

		{
			id_Increment++;
			this.id = id_Increment;
			DateTime tempDate = DateTime.Now;
			this.date = tempDate;
	
		}
		public void Modify(String sentImage, String sentDescription)

		{
			this.imageUrl = sentImage;
			this.description = sentDescription;

		}
	
	}
}
