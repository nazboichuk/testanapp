﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOfShape.Figures
{
	class Circle : Shape
	{
		public double radius;
		double pi = Math.PI;
		public double Perimeter;

		public Circle(string name, double perimeter = 0) : base(name)
		{
			Perimeter = perimeter;
			Console.WriteLine("---------------- Calculate Cirle ----------------");
			Console.WriteLine("Enter the radius:");
			double radius = double.Parse(Console.ReadLine());
			Perimeter = radius * radius * pi;
			Console.WriteLine($"The name of the object is: {Name}, the amount of angles is: {Angles} and the perimeter is {Math.Ceiling(Perimeter)}");

		}
	}
}