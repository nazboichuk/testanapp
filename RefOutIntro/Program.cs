using System;

namespace RefOutIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			//int x = 6;
			var arr = new int[]{ 1, 2, 3, 4, 5 };

			var x = "r";

			var y = '%';
			char w = '^';
			byte t = 255;
			int r = t;
			object o = r;

			int i = (int)o;

			long b = (int)o;

			//short s = (short)r;

			//Console.WriteLine(x);
			//Console.WriteLine(MethodToUseRef(ref x));
			PrintNumber(5, c:5);

			
		}

		//public static int MethodToUseRef(ref int x)
		//{
		//	x = 5;
		//	return x;
		//}

		public static void PrintNumber(int a, int b = 5, int c = 6)
		{

		}

		public static int PrintNumber(int d)
		{
			return d;
		}
	}
}
