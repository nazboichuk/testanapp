﻿using System;
using System.Linq;

namespace LoopsArrays
{
	class Program
	{

		public static void Main(string[] args)
		{
			Console.WriteLine("Factorial task: \n");
			Console.WriteLine("Please, enter any positive number");
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine($"Factorial {num} using recursion: {CalcFactorialUsingRecursion(num)}");
			Console.WriteLine($"Factorial {num} using for loop: {CalcFactorialUsingFor(num)}");
			Console.WriteLine("End of factorial task: \n");

			Console.WriteLine("Calc Even Numbers task: \n");

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


		//public static void Main(string[] args)
		//{
		//	// HW2 задача 2 порахувати к-ість парних числа в масиві даних
		//	int[] testArr1 = new int[] { 1, 5, 8, 13, 22, 0 };
		//	int[] testArr2 = new int[] { 2, 2, 2, 2, 3 };
		//	int[] testArr3 = new int[] {-5, 0, 12, 45, 9 };

		//	Console.WriteLine(CalcEvenNumbers(testArr1));
		//	Console.WriteLine(CalcEvenNumbers(testArr2));
		//	Console.WriteLine(CalcEvenNumbers(testArr3));
		//}

		//public static int CalcEvenNumbers(int[] arr)
		//{
		//	for (int i = 0; i <= 40; i++)
		//	{
		//		if (i % 2 == 0)
		//		{
		//			Console.Write("{0} ", i);
		//		}
		//	}
		//	Console.ReadKey();
		//	return 0;
		//}


		//public static void Main(string[] args)
		//{
		//	// HW3
		//	var s = Console.ReadLine();
		//	Console.WriteLine(CalcNumberOfDigitsInString(s));
		//}

		//public static int CalcNumberOfDigitsInString(string value)
		//{
		//	int counter = 0;
		//	var arr = value.ToCharArray();
		//	foreach (var c in arr)
		//	{
		//		if (Char.IsDigit(c))
		//		{
		//			counter++;
		//		}
		//	}
		//	return counter;
		//}

		// Params theory
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
