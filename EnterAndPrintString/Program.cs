using System;

namespace EnterAndPrintString
{
	class Program
	{
		static void Main(string[] args)
		{
			// HW 1
			// Enter the name of the drink (coffee, tea, juice, water). Print the name of the drink and its price.
			PrintPriceForDrink();
			PrintEachSecondCharacter();

			// HW 2
			// Enter a character string. Print each second character

		}

		public static void PrintPriceForDrink()
		{
			Console.WriteLine("Homework #1");
			Console.WriteLine("Enter your drink name to buy:");
			string name = Console.ReadLine();
			switch (name)
			{
				case "Coffee":
					Console.WriteLine("The price for the coffee: 4$");
					break;
				case "Tea":
					Console.WriteLine("The price for the tea: 2$");
					break;
				case "Juice":
					Console.WriteLine("The price for the juice: 5$");
					break;
				case "Water":
					Console.WriteLine("The water is free");
					break;
				default:
					Console.WriteLine("***** Drink not found ******");
					break;
			}
		}

		public static void PrintEachSecondCharacter()
		{
			Console.WriteLine("Homework #2");
			Console.WriteLine("Enter the words/sentence:");
			string word = Console.ReadLine();

			var result = string.Empty;
			for (var i = 0; i < word.Length; i++)
			{
				if (i % 2 == 0) result += word[i];
			}

			//var output = string.Join(' ', word);
			//var s = string.Join((word % 2) != 0);

			Console.WriteLine(result);
		}
	}
}
