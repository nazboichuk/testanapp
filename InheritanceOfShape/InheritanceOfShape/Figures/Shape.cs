using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOfShape.Figures
{
	public class Shape
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

		public virtual void TypeOfObject()
		{
			Console.WriteLine($"This is an simple object!");
		}
	}
}
