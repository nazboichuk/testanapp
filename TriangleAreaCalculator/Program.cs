using System;

namespace TriangleAreaCalculator
{
	class Program
	{
		public static void Main(string[] args)
		{
			// створити консольну аплікацію, ка обчислює площу трикутника 2 способами:
			// формула Герона, і формула 1/2 висоти трикутника помножена сторону до якої опущена
			//CalculateTriangleArea(3, 5);
			CalculateTriangleArea();
		}

		/*public static void CalculateTriangleArea(double A, double B, double C)
		{
			// Enter Gerone
			Console.WriteLine("#1 Enter the size of the sides of triangle:");
			double P = (A + B + C) / 2;
			double S = Math.Sqrt(P*(P - A)*(P - A)*(P - A));
			Console.WriteLine(S);
		}

		public static void CalculateTriangleArea(double A, double H)
		{
			//  1/2 висоти трикутника помножена сторону до якої опущена
			Console.WriteLine("#2 - Gerone - Enter the size of the sides of triangle:");
			double S = (A * H)/2;
			Console.WriteLine(S);
		}*/
		
		public static void CalculateTriangleArea()
		{
		int x = 0;
		
		Console.WriteLine("Press 1 to use Gerone formula OR press 2 to use other formula:");
			// ввести readline
			switch (x) {
			case 1:
			Console.WriteLine("Переменная равна 1");
			Console.ReadLine();
			// тут ввести 3 числа і реалізація ретурн
			break; 
			case 2: 
			Console.ReadLine();
			Console.WriteLine("Переменная равна 2");
			// тут ввести 2 числа і реалізація ретурн
			break;
			default:
			Console.WriteLine("Что-то другое");
			break;
			}
		}
	}
}
