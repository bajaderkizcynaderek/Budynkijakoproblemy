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
		public bool active { get; set; }

		[XmlAttribute]
		public String name { get; set; }

		[XmlAttribute]
		public String description { get; set; }

		[XmlElement]
		public List<SingleFix> Fixes { get; set; }



		public SingleProduct(String sentName, String sentDescription)
		{
			id_Increment++;
			this.id = id_Increment;
			this.Fixes = new List<SingleFix>();
			this.active = true;
			this.name = sentName;
			this.description = sentDescription;
		}
		public SingleProduct()
		{
			id_Increment++;
			this.id = id_Increment;
			this.Fixes = new List<SingleFix>();
			this.active = true;

		}

		public void AddFix(SingleFix fix)
		{
			this.Fixes.Add(fix);
		}

		// czy to w ogole ma sens?

		public void AddFixWithContents(SingleFix fix, String sentImage, String sentContents)
		{
			//this.Fixes.Add(fix, sentImage, sentContents);
			// no overload for method add takes 3 arguments czyli po co mi konstruktor ze zmiennymi
			// czyli nie ma sensu
			// i duplikuje konstruktor

			this.Fixes.Add(fix);
		}

		public void Deactivate()
		{
			this.active = false;
		}

		public void Activate()
		{
			this.active = true;
		}

		public void Modify(String sentName, String sentDescription)

		{
			this.name = sentName;
			this.description = sentDescription;

		}


	}
}
