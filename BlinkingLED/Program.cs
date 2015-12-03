using System;
using Raspberry.IO.GeneralPurpose;
using Raspberry.IO.GeneralPurpose.Behaviors;

namespace BlinkingLED
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Start Blinking LED...");
			// Here we create a variable to address a specific pin for output
			// There are two different ways of numbering pins--the physical numbering, and the CPU number
			// "P1Pinxx" refers to the physical numbering, and ranges from P1Pin01-P1Pin40
			var led1 = ConnectorPin.P1Pin07.Output();

			// Here we create a connection to the pin we instantiated above
			var connection = new GpioConnection(led1);
			// .. / .-.. --- ...- . / -.-- --- ..-
			//I

//			for (var i = 0; i < 2; i++) {
//				//connection.Toggle (led1);
//				connection.Blink (led1, 250);
//				System.Threading.Thread.Sleep(250);
//			}
//
//			System.Threading.Thread.Sleep(500);
//
//			for (var i = 0; i <1; i++) {
//				connection.Toggle (led1);
//				System.Threading.Thread.Sleep(250);
//			}
//

//
			for (var i = 0; i < 10; i++) {
				// Toggle() switches the high/low (on/off) status of the pin
				connection.Toggle(led1);
				System.Threading.Thread.Sleep(250);
			}

			for (var i = 0; i < 5; i++) {
				// Toggle() switches the high/low (on/off) status of the pin
				connection.Toggle(led1);
				System.Threading.Thread.Sleep(500);
			}

			connection.Close();
			Console.WriteLine ("Stop Blinking LED...");
			}
	}
}
