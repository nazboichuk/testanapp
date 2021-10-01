using System.Collections;
using System.Linq;
using System;

namespace ReturnLastLetter
{
	class Program
	{
		static void Main(string[] args)
		{
			var arr = new int[] { 0, 1 };
			Console.WriteLine("Enter the string:");
			string word = Console.ReadLine();
			Console.WriteLine(RemoveLettersByIndex(word, arr));
		}

		private static string RemoveLettersByIndex(string word, int[] arr)
		{
			foreach (int value in arr)
			{
				word = word.Remove(value, 1);
			}
			return word;
		}
	}
}
