using System;
using System.Xml.Serialization;

namespace ObamaWantsChange.model
{
	public class SingleFix
	{

		[XmlAttribute]
		public int ID { get; set; }

		[XmlAttribute]
		public DateTime date { get; set; }


		public SingleFix()
		// empty contructor is redundant
		{
		}
	}
}
