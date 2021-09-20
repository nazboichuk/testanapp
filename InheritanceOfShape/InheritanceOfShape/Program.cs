using System;

namespace InheritanceOfShape
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please, enter the shape circle radius:");
			var radius = double.Parse(Console.ReadLine());
			var circle = new Figures.Circle(radius);
			Console.WriteLine($"{circle.Name} square is {circle.CalculateSquare()}");
			Console.WriteLine($"{circle.Name} length is {circle.CalculateLength()}");
			Console.WriteLine("****** Job is finished! ******");

			Console.WriteLine("Please, enter the triangle side A:");
			var sideA = double.Parse(Console.ReadLine());
			Console.WriteLine("Please, enter the triangle side B:");
			var sideB = double.Parse(Console.ReadLine());
			Console.WriteLine("Please, enter the triangle side C:");
			var sideC = double.Parse(Console.ReadLine());
			Console.WriteLine("Please, enter the triangle height:");
			var height = double.Parse(Console.ReadLine());
			var triangle = new Figures.Triangle(sideA, sideB, sideC, height);
			Console.WriteLine($"{triangle.Name} square is {triangle.CalculateSquare()}");
			Console.WriteLine($"{triangle.Name} perimetr is {triangle.CalculatePerimetr()}");
			Console.WriteLine("****** Job is finished! ******");

			Console.WriteLine("Please, enter the square side:");
			var sideD = double.Parse(Console.ReadLine());
			var square = new Figures.Square(sideD);
			Console.WriteLine($"{square.Name} square is {square.CalculateSquare()}");
			Console.WriteLine($"{square.Name} perimetr is {square.CalculatePerimetr()}");
			Console.WriteLine("****** Job is finished! ******");

			Console.WriteLine("Please, enter the rectangle side A:");
			var sideE = double.Parse(Console.ReadLine());
			Console.WriteLine("Please, enter the rectangle side B:");
			var sideF = double.Parse(Console.ReadLine());
			var rectangle = new Figures.Rectangle(sideE, sideF);
			Console.WriteLine($"{rectangle.Name} square is {rectangle.CalculateSquare()}");
			Console.WriteLine($"{rectangle.Name} perimetr is {rectangle.CalculatePerimetr()}");
		}
	}
}