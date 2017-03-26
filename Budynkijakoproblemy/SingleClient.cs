using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ObamaWantsChange.model
                          
{
	public class SingleClient
	{

		static public int id_Increment;

		[XmlAttribute]
		public int id { get; set; }

		[XmlAttribute]
		public String name { get; set; }

		[XmlAttribute]
		public String description { get; set; }

		[XmlElement]
		public List<SingleCampaign> Campaigns { get; set; }

		//public String clientName;
		//public String clientDescription;

		public SingleClient()
		{
			id_Increment++;
			this.id = id_Increment;
			this.Campaigns = new List<SingleCampaign>();
		}

		public SingleClient(String clientName, String clientDescription)
		{
			id_Increment++;
			this.id = id_Increment;
			this.name = clientName;
			this.description = clientDescription;
			this.Campaigns = new List<SingleCampaign>();
		}

		public void AddCampaign(SingleCampaign campaign)
		{
			this.Campaigns.Add(campaign);
		}

		public void Add(String clientName, String clientDescription)
		{
			id_Increment++;
			this.id = id_Increment;
			this.name = clientName;
			this.description = clientDescription;
			this.Campaigns = new List<SingleCampaign>();
		}

		public void ListCampaigns()
		{
			Console.WriteLine("*** CURRENT CAMPAIGNS FOR CLIENT: " +name);
			var clientQuery = from SingleCampaign queried in Campaigns select queried;

			foreach (SingleCampaign asked in clientQuery)
			{
				Console.WriteLine(Txt.SHORTDIVIDER);
				Console.WriteLine("  Campaign ID          : " + asked.id);
				Console.WriteLine("  Campaign Name        : " + asked.name);
				Console.WriteLine("  Campaign Description : " + asked.description);
				Console.WriteLine("  Campaign Date        : " + asked.date);
				Console.WriteLine("  Is currently active? : " + asked.active);

				asked.ListProducts();


			}
		}

	}
}
