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
		// stale i zmienne tutaj
		// czy program pracuje:
		private Boolean running = false;

		// stringi tutaj
		// ble bla bla
		private const String PROMPT = "c:\\>";
		private const String HELLO = "when in doubt, type 'help'";

		// instancje? obiektow tutaj
		private MyApplicationModel model = new MyApplicationModel();

		// tu "funkcje", czy też metody

		public void Stop() 
		{
			// czyli tym generujemy metode Aplikacja.Stop() ?
			running = false;
		}

		public void Start()
		{
			running = true;
			// [err] name can be simplified
			System.Console.WriteLine(HELLO);

			while (running)
			{
				System.Console.Write(PROMPT);
				String command = System.Console.ReadLine();
			
			// za chuja nie mam pomysłu jak nawigować po drzewie xml z commandline'a. trzecia kawa!
				// a teraz musze rozpisac na kartce drzewo danych

			
			}

		}


		public static void Main(string[] args) //czemu tu jest public w Xa a w VS 2008 nie?

		{
			MyApplication AppInstance = new MyApplication();
			AppInstance.Start();

			// Console.WriteLine("Hello World!");
		}
	}
}
