using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOfShape.Figures
{
	class Rectangle : Shape
	{
		public int sideA;
		public int sideB;
		public double Perimeter;

		public Rectangle(string name, int angles, double perimeter = 0) : base(name, angles)
		{
			Perimeter = perimeter;
			Console.WriteLine("---------------- Calculate Rectangle ----------------");
			Console.WriteLine("Enter Side A:");
			int sideA = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Side B:");
			int sideB = int.Parse(Console.ReadLine());
			Perimeter = 2 * (sideA + sideB);
			Console.WriteLine($"The name of the object is: {Name}, the amount of angles is: {Angles} and the perimeter is {Perimeter}");
		}
	}
}
