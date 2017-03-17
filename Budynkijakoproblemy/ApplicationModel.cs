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
	}
}
