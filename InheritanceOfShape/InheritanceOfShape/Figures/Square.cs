using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOfShape.Figures
{
	class Square : Shape
	{
		public double sideA;
		public double Perimeter;

		public Square(string name, int angles, double perimeter = 0) : base(name, angles)
		{
			Perimeter = perimeter;
			Console.WriteLine("---------------- Calculate Square ----------------");
			Console.WriteLine("Enter Side:");
			double sideA = double.Parse(Console.ReadLine());
			Perimeter = sideA * sideA;
			Console.WriteLine($"The name of the object is: {Name}, the amount of angles is: {Angles} and the perimeter is {Perimeter}");
		}

		public override void TypeOfObject()
		{
			Console.WriteLine("Current object is a square!");
		}
	}
}
