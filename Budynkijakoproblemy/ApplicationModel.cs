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

		public void AddClient(SingleClient client)
		{
			Clients.Add(client);
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
