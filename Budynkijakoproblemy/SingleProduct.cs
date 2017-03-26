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
		public void ListFixes()
		{
			Console.WriteLine("* CURRENT FIXES FOR PRODUCT: " + name);
			var clientQuery = from SingleFix queried in Fixes select queried;

			foreach (SingleFix asked in clientQuery)
			{
				Console.WriteLine(Txt.SHORTDIVIDER);
				Console.WriteLine("        Fix ID               : " + asked.id);
				Console.WriteLine("        Fix Image URL        : " + asked.imageUrl);
				Console.WriteLine("        Fix Description      : " + asked.description);
				Console.WriteLine("        Fix Date             : " + asked.date);
			


			}
		}

	}
}
