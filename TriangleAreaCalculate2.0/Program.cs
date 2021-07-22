using System;

namespace TriangleAreaCalculator
{
	class Program
	{
		public static void Main(string[] args)
		{
			// створити консольну аплікацію, ка обчислює площу трикутника 2 способами:
			// формула Герона, і формула 1/2 висоти трикутника помножена сторону до якої опущена
			double R = 0;
			CalculateTriangleArea(H:20, A:20, 0, 0, out R);
		}

		public static void CalculateTriangleArea(double H, double A, double B, double C, out double S)
		{
			Console.WriteLine("************** Enter which way you want to use ***************");
			Console.WriteLine("To use Gerone - type 2, use second way - type 1:");
			string nameOfType = Console.ReadLine();
			S = 0;
			switch (nameOfType)
			{
				case "1":
					S = (A * H) / 2;
					Console.WriteLine(S);
					break;
				case "2":
					double P = (A + B + C) / 2;
					S = Math.Sqrt(P * (P - A) * (P - A) * (P - A));
					Console.WriteLine(S);
					break;
				default:
					Console.WriteLine("***** not found ******");
					break;
			}
		}
	}
}
