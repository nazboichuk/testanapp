using System;

namespace TriangleAreaCalculator
{
	class Program
	{
		public static void Main(string[] args)
		{
			// створити консольну аплікацію, ка обчислює площу трикутника 2 способами:
			// формула Герона, і формула 1/2 висоти трикутника помножена сторону до якої опущена
			CalculateTriangleArea(8, 20, 0, 0);
		}

		public static void CalculateTriangleArea(double H, double A, double B, double C)
		{
			Console.WriteLine("************** Enter which way you want to use ***************");
			Console.WriteLine("To use Gerone - type 1, use second way - type 2:");
			string nameOfType = Console.ReadLine();
			switch (nameOfType)
			{
				case "1":
					double S = (A * H) / 2;
					Console.WriteLine(S);
					break;
				case "2":
					double P = (A + B + C) / 2;
					double S1 = Math.Sqrt(P * (P - A) * (P - A) * (P - A));
					Console.WriteLine(S1);
					break;
				default:
					Console.WriteLine("***** not found ******");
					break;
			}
		}
	}
}
