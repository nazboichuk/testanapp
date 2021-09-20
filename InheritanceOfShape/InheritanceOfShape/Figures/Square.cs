using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOfShape.Figures
{
	class Square : Shape
	{
		public double sideA;

		public Square(double sideA) : base("Square")
		{
			this.sideA = sideA;
		}

		public double CalculatePerimetr() => Math.Round(4 * sideA);
		public override double CalculateSquare() => Math.Round(sideA * sideA);
	}
}
