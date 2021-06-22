using System;
using System.Linq;

namespace LoopsArrays
{
	class Program
	{
		public static void Main(string[] args)
		{
			// HW 1
			//Console.WriteLine("Factorial task: \n");
			//Console.WriteLine("Please, enter any positive number");
			//int num = int.Parse(Console.ReadLine());
			//Console.WriteLine($"Factorial {num} using recursion:f {CalcFactorialUsingRecursion(num)}");
			//Console.WriteLine($"Factorial {num} using for loop: {CalcFactorialUsingFor(num)}");
			//Console.WriteLine($"Factorial {num} using while loop: {CalcFactorialUsingWhile(num)}");
			//Console.WriteLine("End of factorial task: \n");

			// HW 2
			Console.WriteLine("Calc Even Numbers task: \n");
			int[] testArr1 = new int[] { 1, 5, 8, 13, 22, 0 };
			int[] testArr2 = new int[] { 2, 2, 2, 2, 3 };
			int[] testArr3 = new int[] { -5, 0, 12, 45, 9 };
			Console.WriteLine(CalcEvenNumbers(testArr1));
			Console.WriteLine(CalcEvenNumbers(testArr2));
			Console.WriteLine(CalcEvenNumbers(testArr3));
			Console.WriteLine("End of the even factorial task task \n");

			// HW 3
			//Console.WriteLine("HW 3 task: \n");
			//Console.WriteLine("Please, enter a string with numbers and characters:");
			//string arr = Console.ReadLine();
			//Console.WriteLine($"The quantity of the string are: {CalcNumberOfDigitsInString(arr)}");
		}

		public static int CalcFactorialUsingRecursion(int n)
		{
			if (n <= 1)
			{
				return 1;
			}

			return n * CalcFactorialUsingRecursion(n - 1);
		}

		public static int CalcFactorialUsingFor(int n)
		{
			int result;
			result = 1;
			for (int i = 1; i <= n; i++)
				result = result * i;
			return result;
		}

		public static int CalcFactorialUsingWhile(int i)
		{
			int result;
			result = 1;

			while (i > 0)
			{
				result = result * i;
				i = i - 1;
			}
			return result;
		}

		// HW2 задача 2 визначити суму парних чисесл в масивах даних
		// HW (new)  Count add
		public static int CalcEvenNumbers(int[] arr)
		{
			for (int i = 0; i <= arr.Length; i++)
			{
				if (i % 2 == 0)
				{
					Console.Write("{0} ", i);
				}
			}
			Console.ReadKey();
			return 0;
		}

		public static int CalcNumberOfDigitsInString(string value)
		{
			int counter = 0;
			var arr = value.ToCharArray();
			foreach (var c in arr)
			{
				if (Char.IsDigit(c))
				{
					counter++;
				}
			}
			return counter;
		}

		//Params theory
		//public static int GetLastItemFromArray(params int[] arr)
		//{
		//	return arr[arr.Length - 1];
		//}

		//bool[] boolArr = { true, false, true, false };
		//int[] intArr = new int[3];
		//long[] longArr = new long[3] { 1, 2, 3 };
		//byte[] byteArr = new byte[] { 1, 2, 3 };

		//var l = boolArr.Length; //return number of items in the array
		//Array.Reverse(longArr); //change order of elements in reverse order
		//Array.Clear(byteArr, 0, byteArr.Length); //set items value to default in a range (0 for int, long, etc.; false for bool, null for strings)
	}
}
