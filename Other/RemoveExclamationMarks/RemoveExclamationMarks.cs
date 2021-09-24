using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveExclamationMarks
{
	class RemoveExclamationMarks
	{
		public static string RemoveMarks()
		{
			Console.WriteLine("Enter the string with exclamations:");
			string phrase = Console.ReadLine();
			phrase = phrase.Replace("!", "");
			Console.WriteLine($"Result is: {phrase}");
			return phrase;
		}
	}
}
