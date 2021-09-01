using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOfShape.Figures
{
	public class Triangle : Shape
	{
		public int sideA;
		public int sideB;
		public int sideC;
		public double Perimeter;

		public Triangle(string name, int angles, double perimeter = 0) : base(name, angles)
		{
			Perimeter = perimeter;
			Console.WriteLine("---------------- Calculate Triangle ----------------");
			Console.WriteLine("Enter Side A:");
			int sideA = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Side B:");
			int sideB = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Side C:");
			int sideC = int.Parse(Console.ReadLine());
			Perimeter = (sideA + sideB + sideC) / 2;
			Console.WriteLine($"The name of the object is: {Name}, the amount of angles is: {Angles} and the perimeter is {Perimeter}");

		}
	}
}
