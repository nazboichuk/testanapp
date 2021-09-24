using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOfShape.Figures
{
	class Circle : Shape
	{
		private double radius;

		public Circle(double radius) : base("Circle")
		{
			this.radius = radius;
		}

		public double CalculateLength() => Math.Round(2 * Math.PI * radius, 2);

		public override double CalculateSquare() => Math.Round(Math.PI * radius * radius, 2);
	}
}
