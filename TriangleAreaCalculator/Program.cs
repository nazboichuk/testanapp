using System;

namespace TriangleAreaCalculator
{
	class Program
	{
		public static void Main(string[] args)
		{
			// створити консольну аплікацію, ка обчислює площу трикутника 2 способами:
			// формула Герона, і формула 1/2 висоти трикутника помножена сторону до якої опущена
			CalculateTriangleArea(3, 5);
		}

		public static void CalculateTriangleArea(double A, double B, double C)
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
		}
	}
}
