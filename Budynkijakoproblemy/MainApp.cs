using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObamaWantsChange.model;
// [err] using directive is unnecessary

namespace ObamaWantsChange
{
	class MyApplication
	{
		private Boolean running = false;
		private MyApplicationModel model = new MyApplicationModel();


		public void Stop() 
		{
			
			running = false;
		}

		public void Start()
		{
			
			running = true;

			Console.WriteLine(Txt.HELLO);


			while (running)
			{
				System.Console.Write(Txt.PROMPT);
				String command = System.Console.ReadLine();


				if (command.Equals("help"))
				{
					System.Console.WriteLine(Txt.NO_HELP_BITCH);
				}

				else if (command.StartsWith("add"))
				{
					/*
					bool nullChecker = (String.IsNullOrEmpty(command.Split(' ')[1]));
					if (!nullChecker)
						// hehe hihi
					{
						String subCommand = command.Split(' ')[1];
						if (subCommand.Equals("client"))
						{
						}
						// tu bedzie model.addclient....

						// no i co. klient to skomplikowana lista danych, w00t w00t nawet nie wiem jaki to typ
						// jak napisac entry interface do tego lols.
						// ide robic hello worldy

						//model.AddClient(clientName);
						// SingleClient client = new SingleClient();
						// client.AddCampaign(new SingleCampaign());
						// model.AddClient(client);

					}
					else
					{
						System.Console.WriteLine(Txt.YOU_FORGOT);
						return;
					}
					*/
				}
				else if (command.StartsWith("save"))
				{
					String fileName = command.Split(' ')[1];
					model.Save(fileName);
				}

			// Pan wybaczy, probujemy rzucac gownem w sciane

				else if (command.Equals("test"))
				{
					this.AddTheShit();
				}
				else if (command.Equals("list"))
				{

					model.ListTheList();
				}
				else if (command.Equals("navi"))
				{

					model.Navigate();
				}

				else if (command.StartsWith("load"))
				{
					String fileName = command.Split(' ')[1];

					model.Load(fileName);
				}
				else if (command.Equals("exit"))
				{
					Stop();
				}


				// koniec przewalenia

			
			}

		}

		public void AddTheShit()
		{
			// b/c i'm impatient, co za gowno posrane. na bank trzeba to przewalic do odpowiednich obiektow 
			// aaaale nieeee wieeem jaaaaaaaaaaaaaaaaaak
			// tak samo obiekty nie powinny same robic writeline
			// tylko zwracac wartosci do renderera, aleeeee nieeee wieeeeem jeszczeeee
			// JAAAAAAAAAAAK

			Console.WriteLine(Txt.ADDSHIT);

			SingleClient client = CreateNewClient();

		    // nowa kampania

			Console.WriteLine(Txt.NEW_CAMPAIGN_NAME);
			String newCampaignName = System.Console.ReadLine();

			Console.WriteLine(Txt.NEW_CAMPAIGN_DESC);
			String newCampaignDescription = System.Console.ReadLine();

		    SingleCampaign campaign = model.AddNewCampaign(client.Id, newCampaignName, newCampaignDescription);

			Console.WriteLine(Txt.DIVIDER);

			// nowy produkt

			Console.WriteLine(Txt.NEW_PRODUCT_NAME);
			String newProductName = System.Console.ReadLine();

			Console.WriteLine(Txt.NEW_PRODUCT_DESC);
			String newProductDescription = System.Console.ReadLine();
		    SingleProduct product = model.AddNewProduct(campaign.id, newProductName, newProductDescription);

			Console.WriteLine(Txt.DIVIDER);

			// i nowy, testowy fiks

			Console.WriteLine(Txt.NEW_FIX_DESC);
			String newFixDesc = System.Console.ReadLine();

			Console.WriteLine(Txt.NEW_FIX_URL);
			String newFixUrl = System.Console.ReadLine();

			SingleFix fixToAdd = new SingleFix(newFixUrl, newFixDesc);
			product.Fixes.Add(fixToAdd);
			Console.WriteLine("Added fix with ID: " + fixToAdd.id + " , description: " + fixToAdd.description + ", image URL: " + fixToAdd.imageUrl);


			Console.WriteLine(Txt.DIVIDER);

		}

	    private SingleClient CreateNewClient()
	    {
	        Console.WriteLine(Txt.NEW_CLIENT_NAME);
	        String newClientName = System.Console.ReadLine();

	        Console.WriteLine(Txt.NEW_CLIENT_DESC);
	        String newClientDescription = System.Console.ReadLine();

	        SingleClient client = model.AddNewClient(newClientName, newClientDescription);

	        Console.WriteLine(Txt.DIVIDER);
	        return client;
	    }

	    public static void Main(string[] args)

		{
			MyApplication AppInstance = new MyApplication();

			AppInstance.Start();

		}



	}
}
