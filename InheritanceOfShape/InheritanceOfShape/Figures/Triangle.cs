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
		public double height;

		public Triangle(double sideA, double sideB, double sideC, double height) : base("Triangle")
		{
			this.sideA = sideA;
			this.sideB = sideB;
			this.sideC = sideC;
			this.height = height;
		}

		public double CalculatePerimetr() => Math.Round(sideA + sideB + sideC);

		public override double CalculateSquare() => Math.Round(height * sideA / 2, 2);
	}
}
