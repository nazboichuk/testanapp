using System;

namespace SimpleTasksWithLoopsAndConditions
{
	class Program
	{
		static void Main(string[] args)
		{
			ReverseStringUsingJoin();
			ReverseStringUsingFor();
		}

		// HW 4
		// Make a function that will return a greeting statement that uses an input;
		// your program should return, "Hello, <name> how are you doing today?"
		/*public static void Greeting()
		{
			Console.Write("Enter the name: ");
			string name = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Hello, {0} how are you doing today?", name);
			Console.ReadKey();
		}*/

		// HW 6 - complete the solution so that it reverses all of the words within the string passed in.
		// Example: "The greatest victory is that which requires no battle "-- > "battle no requires which that is victory greatest The"
		// concat reversed array with for loop
		// delete the last space of the outpout result
		public static void ReverseStringUsingJoin()
		{
			string rev = "The greatest victory is that which requires no battle";
			string[] subs = rev.Split(' ');
			Array.Reverse(subs);
			var output = string.Join(' ', subs);
			Console.WriteLine(output);
		}

		public static void ReverseStringUsingFor()
		{
			string rev = "The greatest victory is that which requires no battle ";
			string[] subs = rev.Split(' ');
			string output = string.Empty;

			for (int i = subs.Length - 1; i >= 0; i--)
			{
				output += subs[i] + " ";
			}

			Console.WriteLine(output.Trim());
			Console.ReadKey();
		}
	}
}
