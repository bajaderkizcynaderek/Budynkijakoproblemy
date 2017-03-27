using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using Budynkijakoproblemy;

namespace ObamaWantsChange.model
{
    [XmlRoot]
    public class MyApplicationModel
    {
        [XmlElement]
        public List<SingleClient> Clients { get; set; }

        public MyApplicationModel()
        {
            this.Clients = new List<SingleClient>();
        }

        public SingleClient AddNewClient(string newClientName, string newClientDescription)
        {
            SingleClient client = new SingleClient(newClientName, newClientDescription);
            this.Clients.Add(client);
            Logger.Log("Added Client with ID: " + client.Id + " , name: "
                       + client.Name + ", description: " + client.Description);

            return client;
        }

        public void ListTheList()
        {
            Console.WriteLine("****** CURRENT CLIENT LIST");
            var clientQuery = from SingleClient queried in Clients select queried;

            foreach (SingleClient asked in clientQuery)
            {
                Console.WriteLine(Txt.DIVIDER);
                Console.WriteLine("Client ID         : " + asked.Id);
                Console.WriteLine("Client Name       : " + asked.Name);
                Console.WriteLine("Client Description: " + asked.Description);
                asked.ListCampaigns();
            }
        }

        public void Navigate()
        {
            Console.WriteLine("ENTER [CLIENT ID] OR TYPE EXIT");
            var clientQuery = from SingleClient queried in Clients select queried;

            foreach (SingleClient asked in clientQuery)
            {
                Console.WriteLine(Txt.DIVIDER);
                Console.WriteLine("ID: " + asked.Id + " | Client Name: " + asked.Name);
                //asked.ListCampaigns();
            }

            System.Console.Write(Txt.NAVIPROMPT);
            String command = System.Console.ReadLine();
            int commandint = Convert.ToInt32(command);

            var item = clientQuery.First(nosek => nosek.Id == commandint);
            item.Navigate();

            //switch command {
            //}
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
            MyApplicationModel model = (MyApplicationModel) serializer.Deserialize(inputStream);
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


        public SingleCampaign AddNewCampaign(int clientId, string newCampaignName, string newCampaignDescription)
        {
            SingleClient client = FindClientById(clientId);
            SingleCampaign campaign = client.AddCampaign(newCampaignName, newCampaignDescription);

            Console.WriteLine("Added Campaign with ID: " + campaign.id + " , name: " + campaign.name
                              + ", description: " + campaign.description);

            return campaign;
        }

        public SingleProduct AddNewProduct(int campaignId, string newProductName, string newProductDescription)
        {
            SingleCampaign campaign = FindCampaignById(campaignId);
            SingleProduct product = campaign.AddProduct(newProductName, newProductDescription);

            Logger.Log("Added Product with ID: " + product.id + " , name: " + product.name
                       + ", description: " + product.description);

            return product;
        }

        private SingleClient FindClientById(int id)
        {
            return this.Clients.First(client => client.Id == id);
        }

        private SingleCampaign FindCampaignById(int campaignId)
        {
            var found = from client in this.Clients
                from campaign in client.Campaigns
                where campaign.id == campaignId
                select campaign;

            //TODO handle not found
            return found.First();
        }
    }
}