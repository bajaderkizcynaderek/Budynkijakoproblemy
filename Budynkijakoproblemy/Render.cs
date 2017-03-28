using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using ObamaWantsChange.model;

namespace ObamaWantsChange
{
	public static class Render
	{
		public static void Rend(String message)
		{
			Console.WriteLine(message);
		}
		public static void Rendmany( String [] messages)
		{
			foreach (String message in messages)
			{
				Console.WriteLine(message);
			}  
		}
	}

}
