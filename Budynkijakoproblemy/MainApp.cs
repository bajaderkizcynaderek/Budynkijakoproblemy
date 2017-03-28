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

			Render.Rend(Txt.HELLO);


			while (running)
			{
				Render.Rend(Txt.PROMPT);
				Input.Wait();

			}

		}


		public static void Main(string[] args) 

		{
			MyApplication AppInstance = new MyApplication();

			AppInstance.Start();




		}



	}
}
