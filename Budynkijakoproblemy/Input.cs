using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using ObamaWantsChange.model;

namespace ObamaWantsChange
{
	public static class Input
	{
		public Input()
		{
		}
		public static void Wait()
		{
			String command = System.Console.ReadLine();


			if (command.Equals("help"))
			{
				Render.Rend(Txt.NO_HELP_BITCH);
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

				model.AddTheShit();
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
}
