using System;
using System.Collections.Generic;
using System.Text;

namespace ToFly
{
	class Bird : IFlyable
	{
		public string name { get; set; }
		bool canFly { get; set; }

		public Bird(string name, bool canFly)
		{
			this.name = name;
			this.canFly = canFly;
		}

		public void Fly()
		{
			Console.WriteLine($"The name of the Bird is {name}, and flying possibility is {canFly}.");
		}
	}
}
