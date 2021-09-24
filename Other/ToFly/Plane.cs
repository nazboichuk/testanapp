using System;
using System.Collections.Generic;
using System.Text;

namespace ToFly
{
	class Plane : IFlyable
	{
		public string mark { get; set; }
		bool highFly { get; set; }

		public Plane(string mark, bool highFly)
		{
			this.mark = mark;
			this.highFly = highFly;
		}

		public void Fly()
		{
			Console.WriteLine($"The sign of the plane is {mark} and possibility of the high flying is {highFly}.");
		}
	}
}
