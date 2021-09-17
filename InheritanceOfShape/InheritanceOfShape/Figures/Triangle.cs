using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOfShape.Figures
{
	public class Triangle : Shape
	{
		public double sideA;
		public double sideB;
		public double sideC;
		public double Perimeter;

		public Triangle(string name, int angles, double perimeter = 0) : base(name, angles)
		{
			Perimeter = perimeter;
			Console.WriteLine("---------------- Calculate Triangle ----------------");
			Console.WriteLine("Enter Side A:");
			double sideA = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter Side B:");
			double sideB = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter Side C:");
			double sideC = double.Parse(Console.ReadLine());
			Perimeter = (sideA + sideB + sideC) / 2;
			Console.WriteLine($"The name of the object is: {Name}, the amount of angles is: {Angles} and the perimeter is {Perimeter}");
		}

		public override void TypeOfObject()
		{
			Console.WriteLine("Current object is a square!");
		}
	}
}
