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
		// b/c i'm impatient, co za gowno posrane. na bank trzeba to przewalic do odpowiednich obiektow 
			// aaaale nieeee wieeem jaaaaaaaaaaaaaaaaaak
			// tak samo obiekty nie powinny same robic writeline
			// tylko zwracac wartosci do renderera, aleeeee nieeee wieeeeem jeszczeeee
			// JAAAAAAAAAAAK

			Console.WriteLine(Txt.ADDSHIT);

			// nowy klient

			Console.WriteLine(Txt.NEW_CLIENT_NAME);

			String newClientName = System.Console.ReadLine();

			Console.WriteLine(Txt.NEW_CLIENT_DESC);

			String newClientDescription = System.Console.ReadLine();

			SingleClient clientToAdd = new SingleClient(newClientName, newClientDescription);

			Clients.Add(clientToAdd);

			Console.WriteLine("Added Client with ID: "+ clientToAdd.id + " , name: " +clientToAdd.name + ", description: " + clientToAdd.description);

			Console.WriteLine(Txt.DIVIDER);

			// nowa kampania

			Console.WriteLine(Txt.NEW_CAMPAIGN_NAME);

			String newCampaignName = System.Console.ReadLine();

			Console.WriteLine(Txt.NEW_CAMPAIGN_DESC);

			String newCampaignDescription = System.Console.ReadLine();

			SingleCampaign campaignToAdd = new SingleCampaign(newCampaignName,newCampaignDescription);

			clientToAdd.Campaigns.Add(campaignToAdd);

			Console.WriteLine("Added Campaign with ID: " + campaignToAdd.id + " , name: " + clientToAdd.name + ", description: " + clientToAdd.description);


			Console.WriteLine(Txt.DIVIDER);

			// nowy produkt

			Console.WriteLine(Txt.NEW_PRODUCT_NAME);

			String newProductName = System.Console.ReadLine();

			Console.WriteLine(Txt.NEW_PRODUCT_DESC);

			String newProductDescription = System.Console.ReadLine();

			SingleProduct productToAdd = new SingleProduct(newProductName, newProductDescription);

			campaignToAdd.Products.Add(productToAdd);


			Console.WriteLine("Added Product with ID: " + productToAdd.id + " , name: " + productToAdd.name + ", description: " + productToAdd.description);


			Console.WriteLine(Txt.DIVIDER);

			// i nowy, testowy fiks

			Console.WriteLine(Txt.NEW_FIX_DESC);

			String newFixDesc = System.Console.ReadLine();

			Console.WriteLine(Txt.NEW_FIX_URL);

			String newFixUrl = System.Console.ReadLine();

			SingleFix fixToAdd = new SingleFix(newFixUrl, newFixDesc);

			productToAdd.Fixes.Add(fixToAdd);


			Console.WriteLine("Added fix with ID: " + fixToAdd.id + " , description: " + fixToAdd.description + ", image URL: " + fixToAdd.imageUrl);


			Console.WriteLine(Txt.DIVIDER);

		}

		public void ListTheList()
		{
			Console.WriteLine("****** CURRENT CLIENT LIST");
			var clientQuery = from SingleClient queried in Clients select queried;

			foreach (SingleClient asked in clientQuery)
			{
				Console.WriteLine(Txt.DIVIDER);
				Console.WriteLine("Client ID         : " + asked.id);
				Console.WriteLine("Client Name       : " + asked.name);
				Console.WriteLine("Client Description: " + asked.description);
				asked.ListCampaigns();
   
			
			}
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
