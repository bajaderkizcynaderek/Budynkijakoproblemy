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
                    this.AddTheShit();
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
            Console.WriteLine("Added fix with ID: " + fixToAdd.id + " , description: " + fixToAdd.description +
                              ", image URL: " + fixToAdd.imageUrl);


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

        public void ListTheList()
        {
            Console.WriteLine("****** CURRENT CLIENT LIST");

            ListClients(model.Clients);
        }

        private void ListClients(IEnumerable<SingleClient> clientQuery)
        {
            foreach (SingleClient asked in clientQuery)
            {
                Console.WriteLine(Txt.DIVIDER);
                Console.WriteLine("Client ID         : " + asked.Id);
                Console.WriteLine("Client Name       : " + asked.Name);
                Console.WriteLine("Client Description: " + asked.Description);
                ListCampaigns(asked.Campaigns);
            }
        }

        private void ListCampaigns(IEnumerable<SingleCampaign> campaigns)
        {
            foreach (SingleCampaign asked in campaigns)
            {
                Console.WriteLine(Txt.SHORTDIVIDER);
                Console.WriteLine("  Campaign ID          : " + asked.id);
                Console.WriteLine("  Campaign Name        : " + asked.name);
                Console.WriteLine("  Campaign Description : " + asked.description);
                Console.WriteLine("  Campaign Date        : " + asked.date);
                Console.WriteLine("  Is currently active? : " + asked.active);

                ListProducts(asked.Products);
            }
        }

        private void ListProducts(IEnumerable<SingleProduct> products)
        {
            foreach (SingleProduct asked in products)
            {
                Console.WriteLine(Txt.SHORTDIVIDER);
                Console.WriteLine("    Product ID           : " + asked.id);
                Console.WriteLine("    Product Name         : " + asked.name);
                Console.WriteLine("    Product Description  : " + asked.description);
                Console.WriteLine("    Is currently active? : " + asked.active);

                ListFixes(asked.Fixes);
            }
        }

        private void ListFixes(List<SingleFix> fixes)
        {
            foreach (SingleFix asked in fixes)
            {
                Console.WriteLine(Txt.SHORTDIVIDER);
                Console.WriteLine("        Fix ID               : " + asked.id);
                Console.WriteLine("        Fix Image URL        : " + asked.imageUrl);
                Console.WriteLine("        Fix Description      : " + asked.description);
                Console.WriteLine("        Fix Date             : " + asked.date);
            }
        }

        public static void Main(string[] args)

        {
            MyApplication AppInstance = new MyApplication();

            AppInstance.Start();
        }
    }
}