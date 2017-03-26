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

		private const String PROMPT = "c:\\>";
		private const String HELLO = "when in doubt, type 'help'";
		private const String NO_HELP_BITCH = "There is no spoon and there is no help.";
		private const String NEW_CLIENT_NAME = "Enter new client name:";
		private const String NEW_CLIENT_DESC = "Enter new client description:";
		private const String NEW_CAMPAIGN_NAME = "Enter new campaign name:";
		private const String NEW_CAMPAIGN_DESC = "Enter new campaign description:";
		private const String NEW_PRODUCT_NAME = "Enter new product name:";
		private const String NEW_PRODUCT_DESC = "Enter new product description:";
		private const String NEW_FIX_NAME = "Give your fix a name:";
		private const String NEW_FIX_DESC = "Explain what you did:";
		private const String YOU_FORGOT = "You forgot Poland!";



		private MyApplicationModel model = new MyApplicationModel();


		public void Stop() 
		{
			// czyli tym generujemy metode Aplikacja.Stop() ?
			running = false;
		}

		public void Start()
		{
			running = true;
			// [err] name can be simplified
			Console.WriteLine(HELLO);

			while (running)
			{
				System.Console.Write(PROMPT);
				String command = System.Console.ReadLine();
			
			
					if (command.Equals("help"))
					{
					System.Console.WriteLine(NO_HELP_BITCH);
					}

				else if (command.StartsWith("add"))
				{

					bool nullChecker = (String.IsNullOrEmpty(command.Split(' ')[1]));
					if (!nullChecker)

					{
						String subCommand = command.Split(' ')[1];
						if (subCommand.Equals("client"))
						{
						}
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
						System.Console.WriteLine(YOU_FORGOT);
						return;
					}
				}
					else if (command.StartsWith("save"))
					{
						String fileName = command.Split(' ')[1];
						model.Save(fileName);
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


		public static void Main(string[] args) //czemu tu jest public w Xa a w VS 2008 nie?

		{
			MyApplication AppInstance = new MyApplication();
			AppInstance.Start();


			/* to wpisał pan dyrektor i na chwile to zostawiamy
			 * 
			 * SingleProduct product = new SingleProduct();
			product.id = 5;
			product.name = "hello";

			SingleProduct product2 = new SingleProduct(1, false, "produkt");


			// Console.WriteLine("Hello World!");
			*/


		}
	}
}
