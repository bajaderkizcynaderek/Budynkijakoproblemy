using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZarzadzanieZmiana.model;
// using directive is unnecessary

namespace ZarzadzanieZmiana
{
	class Aplikacja
	{
		// stale i zmienne tutaj
		// czy program pracuje:
		private Boolean running = false;

		// stringi tutaj
		// ble bla bla
		private const String PROMPT = "c:\\>";
		private const String HELLO = "when in doubt, type 'help'";

		// instancje? obiektow tutaj
		private ModelAplikacji model = new ModelAplikacji();

		// tu "funkcje", czy też metody

		public void Stop() 
		{
			// czyli tym generujemy metode Aplikacja.Stop() ?
			running = false;
		}

		public void Start()
		{
			running = true;
			System.Console.WriteLine(HELLO);

			while (running)
			{
				System.Console.Write(PROMPT);
				String command = System.Console.ReadLine();
			
			// za chuja nie mam pomysłu jak nawigować po drzewie xml z commandline'a. trzecia kawa!


			
			}

		}


		public static void Main(string[] args) //czemu tu jest public w Xa a w VS 2008 nie?

		{
			Aplikacja InstancjaAplikacji = new Aplikacja();
			InstancjaAplikacji.Start();

			// Console.WriteLine("Hello World!");
		}
	}
}
