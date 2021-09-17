using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOfShape.Figures
{
	public abstract class Shape
	{
		public string Name { get; }
		public int Angles { get; }

		public Shape(string name, int angles)
		{
			Name = name;
			Angles = angles;
		}

		public Shape(string name)
		{
			Name = name;
		}

		public abstract void TypeOfObject()
		{
		}
	}
}
