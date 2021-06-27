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


//		// HW 6
//		// Complete the solution so that it reverses all of the words within the string passed in.
//		// Example: "The greatest victory is that which requires no battle"-- > "battle no requires which that is victory greatest The"

//		// concat reversed array with for loop
		public static void ReverseString()
		{
			string rev = Console.ReadLine(); // hello world
			string[] subs = rev.Split(' '); // [hello, world]
			Array.Reverse(subs); // [world, hello]
			var output = string.Join(' ', subs); // world hello
			Console.WriteLine(output);
			
			for (int i = 0; i < length; i++)
			{

			}

			Console.ReadKey();
		}
	}
}
