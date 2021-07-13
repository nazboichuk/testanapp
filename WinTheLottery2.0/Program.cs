using System;

namespace WinTheLotteryProject
{
	class Program
	{
		static void Main(string[] args)
		{
			// Користувач вводить будь-яке число в діапазоні від 1 до 10 включно. Якщо користувач вгадав число - тоді вивести повідомлення, що число відгадане
			UserCanWinTheLottery();
		}

		public static void UserCanWinTheLottery(int usernumber = 0, int winnumber = 7)
		{
			Console.WriteLine("----------------- Homework #1 --------------------\nEnter the lottery number:");

			while (usernumber != winnumber) // Takes more time that usual (had a thoat about switch case approach)
			{
				usernumber = Int32.Parse(Console.ReadLine());
				Console.Clear();

				if (usernumber == winnumber)
				{
					Console.WriteLine("You win!\n----------------- Spend your money mindly! --------------------");
				}
				else if (usernumber > 10)
				{
					Console.WriteLine("Incorrect number :(\nLet the next guy to input the number!\nEnter the lottery number:");
				}
				else
				{
					Console.WriteLine("You lose :(\nLet the next guy to input the number!\nEnter the lottery number:");
				}
			}
		}

	}
}
