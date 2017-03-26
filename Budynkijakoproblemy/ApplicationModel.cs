using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace ObamaWantsChange.model
{
	[XmlRoot]
	public class MyApplicationModel
	{
		[XmlElement]
		public List<SingleClient> Clients;

		public MyApplicationModel()
		{
			this.Clients = new List<SingleClient>();
		}

		public void AddClient(SingleClient client) // reeeeetaaard
		{


			/* to wpisał pan dyrektor i na chwile to zostawiamy
			 * 
			 * SingleProduct product = new SingleProduct();
			product.id = 5;
			product.name = "hello";

			SingleProduct product2 = new SingleProduct(1, false, "produkt");


			// Console.WriteLine("Hello World!");
			*/
		}

		public void AddTheShit()
		{
		// b/c i'm impatient

			Console.WriteLine(Txt.ADDSHIT);

			// nowy klient

			Console.WriteLine(Txt.NEW_CLIENT_NAME);
			String newClientName = System.Console.ReadLine();
			Console.WriteLine(Txt.NEW_CLIENT_DESC);
			String newClientDescription = System.Console.ReadLine();

			SingleClient clientToAdd = new SingleClient(newClientName, newClientDescription);
			//clientToAdd.name = newClientName;
			//clientToAdd.description = newClientDescription;
			Console.WriteLine(Txt.WHATID);
			Console.WriteLine(clientToAdd.id);
			Console.WriteLine(Txt.DIVIDER);

			// nowa kampania

			Console.WriteLine(Txt.NEW_CAMPAIGN_NAME);

			String newCampaignName = System.Console.ReadLine();

			Console.WriteLine(Txt.NEW_CAMPAIGN_DESC);

			String newCampaignDescription = System.Console.ReadLine();

			SingleCampaign campaignToAdd = new SingleCampaign(newCampaignName,newCampaignDescription);

			clientToAdd.Campaigns.Add(campaignToAdd);
			Console.WriteLine(Txt.WHATID);
			Console.WriteLine(campaignToAdd.id);
			Console.WriteLine(Txt.DIVIDER);

			// urwa, ale jestem glupi. i co teraz, wladowalem to tam i jak sie do tego odwolac... kurwaaaaa
			// nowy produkt
			// na razie zostawmy zobaczmy czy nie zadeklarowalem tego lokalnie




		}

		public void ListTheList()
		{
			
		}


		// nastepujacy po tym kod przewalam z przykladu as-is, zmieniajac tylko nazwy
		// na razie nie chce sie przejmowac operacjami write/read
		// chcialbym zrozumiec dodawanie odejmowanie danych.

		public void Save(String fileName)
		{
			XmlSerializer serializer = new XmlSerializer(this.GetType());
			Stream outputStream = CreateOutputStream(fileName);
			serializer.Serialize(outputStream, this);
			outputStream.Close();
		}

		public void Load(String fileName)
		{
			XmlSerializer serializer = new XmlSerializer(this.GetType());
			Stream inputStream = CreateInputStream(fileName);
			MyApplicationModel model = (MyApplicationModel)serializer.Deserialize(inputStream);
			Clients = model.Clients;

			inputStream.Close();
		}

		private Stream CreateOutputStream(String fileName)
		{
			Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);

			return stream;
		}

		private Stream CreateInputStream(String fileName)
		{
			Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);

			return stream;
		}

		// tu konczy sie przewalony na slepo kot



	}
}
