using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOfShape.Figures
{
	class Rectangle : Shape
	{
		public double sideA;
		public double sideB;

		public Rectangle(double sideA, double sideB) : base("Rectangle")
		{
			this.sideA = sideA;
			this.sideB = sideB;
		}

		public double CalculatePerimetr() => Math.Round(2 * (sideA + sideB));
		public override double CalculateSquare() => Math.Round(sideA * sideB);
	}
}
