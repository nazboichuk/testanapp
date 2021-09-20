using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOfShape.Figures
{
	public abstract class Shape
	{
		public string Name { get; }

		public Shape(string name)
		{
			Name = name;
		}

		public abstract double CalculateSquare();
	}
}
