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
	public bool active { get; set; }

	[XmlAttribute]
	public String name { get; set; }

	[XmlAttribute]
	public String description { get; set; }

	[XmlElement]
	public List<SingleProduct> Products { get; set; }

		//public String sentName;
		//public String sentDescription;

		public SingleCampaign()
		{
			id_Increment++;
			this.id = id_Increment;
			DateTime tempDate = DateTime.Now;
			this.date = tempDate;
			this.Products = new List<SingleProduct>();
			this.active = true;

		}


		public SingleCampaign(String sentName, String sentDescription)
		{
			id_Increment++;
			this.id = id_Increment;
			DateTime tempDate = DateTime.Now;
			this.date = tempDate;
			this.Products = new List<SingleProduct>();
			this.active = true;
			this.name = sentName;
			this.description = sentDescription;

		}

		public void Add( String sentName, String sentDescription)
		{
			id_Increment++;
			this.id = id_Increment;
			DateTime tempDate = DateTime.Now;
			this.date = tempDate;
			this.Products = new List<SingleProduct>();
			this.active = true;
			this.name = sentName;
			this.description = sentDescription;

		}

		public void AddProduct(SingleProduct product)
		{
			this.Products.Add(product);
		}

		public void Deactivate(){
			this.active = false;
		}

		public void Activate()
		{
			this.active = true;
		}
		/* ne rozumi :)
		 * 
		public getActiveProducts(Products )
		{
			// tu wywala te z flaga akt
		}
		public getAllProducts(Products))
		{
			// tu wywala wszystkie, co to zwraca??? liste obiektow products,lol
		}
*/
	}
}
