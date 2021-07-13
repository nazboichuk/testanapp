using System;

namespace WinTheLotteryProject

{
	class Program
	{
		static void Main(string[] args)
		{
			// HW 1
			// Користувач вводить будь-яке число в діапазоні від 1 до 10 включно
			// далі екрані консолі очищається
			// І консоль виводить повідомлення, щоб інший користувач вгадав запсиане число
			// якщо користувач вгадав число - тоді вивести повідомлення, що число відгадане
			WinTheLottery();
		}

		public static void WinTheLottery()
		{
			int winNumber = 7;
			int userNumber = 1 <= x && x <= 10;

			Console.WriteLine("----------------- Homework #1 --------------------");
			Console.WriteLine("Enter the number between 1 and 10:");
			int userNumber = Console.ReadLine();

			var result = string.Empty;
			for (var i = 0; i <= 10; i++)
			{
				if (i = 7) result;
			}
			Console.Clear();
			Console.WriteLine(result);
		}
	}
}
