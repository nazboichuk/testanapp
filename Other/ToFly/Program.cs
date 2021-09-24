using System;

namespace ToFly
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the abstract things!");
			IFlyable[] flyables = new IFlyable[] { new Bird("Sparrow", true), new Plane("Boing", true) };
			foreach (var item in flyables)
			{
				item.Fly();
			}
		}
	}
}
