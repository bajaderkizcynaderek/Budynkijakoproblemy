using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ObamaWantsChange.model
                          
{
	public class SingleClient
	{

	    private static int lastId;

		[XmlAttribute]
		public int Id { get; set; }

		[XmlAttribute]
		public String Name { get; set; }

		[XmlAttribute]
		public String Description { get; set; }

		[XmlElement]
		public List<SingleCampaign> Campaigns { get; set; }


		public SingleClient()
		{
			lastId++;
			this.Id = lastId;
			this.Campaigns = new List<SingleCampaign>();
		}

		public SingleClient(String clientName, String clientDescription)
		{
			lastId++;
			this.Id = lastId;
			this.Name = clientName;
			this.Description = clientDescription;
			this.Campaigns = new List<SingleCampaign>();
		}

		public void AddCampaign(SingleCampaign campaign)
		{
			this.Campaigns.Add(campaign);
		}

	    public SingleCampaign AddCampaign(String newCampaignName, String newCampaignDescription)
	    {
	        SingleCampaign campaign = new SingleCampaign(newCampaignName, newCampaignDescription);
	        AddCampaign(campaign);

	        return campaign;
	    }

		public void Navigate()
		{
			Console.WriteLine("ENTER [CAMPAIGN ID] OR TYPE EXIT");
			var campQuery = from SingleCampaign queried in Campaigns select queried;

			foreach (SingleCampaign asked in campQuery)
			{
				Console.WriteLine(Txt.DIVIDER);
				Console.WriteLine("ID: " + asked.id + " | Campaign Name: " + asked.name);
				//asked.ListCampaigns();

			}

			System.Console.Write("CLI["+Id+"] : "+Txt.NAVIPROMPT);
			String command = System.Console.ReadLine();
			int commandint = Convert.ToInt32(command);

			var item = campQuery.First(nosek => nosek.id == commandint);
			item.ListProducts();

			//switch command {
			//}
		}

		public void ListCampaigns()
		{
			Console.WriteLine("*** CURRENT CAMPAIGNS FOR CLIENT: " +Name);
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
