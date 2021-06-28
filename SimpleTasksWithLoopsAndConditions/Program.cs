using System;

namespace SimpleTasksWithLoopsAndConditions
{
	class Program
	{
		static void Main(string[] args)
		{
			ReverseString();
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
		public static void ReverseString()
		{
			string rev = "The greatest victory is that which requires no battle ";
			string[] subs = rev.Split(' ');
			Array.Reverse(subs);
			var output = string.Join(' ', subs);
			Console.WriteLine(output.TrimStart(' '));

			for (int i = subs.Length - 1; i >= 0; i--)
			{
				rev += subs[i] + " ";
			}

			Console.ReadKey();
		}
	}
}
