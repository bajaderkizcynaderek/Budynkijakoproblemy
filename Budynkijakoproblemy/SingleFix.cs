﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ObamaWantsChange.model
{
	public class SingleFix
	{

		[XmlAttribute]
		public int id { get; set; }

		[XmlAttribute]
		public DateTime date { get; set; }

		[XmlAttribute]
		public String imageUrl { get; set; }

		[XmlAttribute]
		public String description { get; set; }

		public SingleFix()
		// empty contructor is redundant
		{
		}
	}
}
