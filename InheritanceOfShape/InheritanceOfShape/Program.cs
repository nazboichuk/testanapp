using System;

namespace InheritanceOfShape
{
	class Program
	{
		static void Main(string[] args)
		{
			var myShape1 = new Figures.Triangle("Triangle", 3);
			var myShape2 = new Figures.Rectangle("Rectangle", 4);
			myShape2.TypeOfObject();
			var myShape3 = new Figures.Circle("Circle");
			var myShape4 = new Figures.Square("Square", 4);
			myShape4.TypeOfObject();
		}
	}
}