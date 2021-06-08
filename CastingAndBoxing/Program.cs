using System;

namespace CastingAndBoxing
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 100;
			long b = a;

			int i = 10;
			object o = i;
			long x = (int)o;
			Console.WriteLine(x);
		}
	}
}
