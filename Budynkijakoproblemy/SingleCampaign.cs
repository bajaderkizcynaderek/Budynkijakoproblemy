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

		public void ListProducts()
		{
			Console.WriteLine("** CURRENT PRODUCTS FOR CAMPAIGN: " + name);
			var clientQuery = from SingleProduct queried in Products select queried;

			foreach (SingleProduct asked in clientQuery)
			{
				Console.WriteLine(Txt.SHORTDIVIDER);
				Console.WriteLine("    Product ID           : " + asked.id);
				Console.WriteLine("    Product Name         : " + asked.name);
				Console.WriteLine("    Product Description  : " + asked.description);
				Console.WriteLine("    Is currently active? : " + asked.active);

				asked.ListFixes();


			}
		}

	}
}
