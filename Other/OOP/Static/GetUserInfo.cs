using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
	public static class GetUserInfo
	{
		public static string GetFirstName()
		{
			Console.WriteLine("The Name is:");
			string userName = (Console.ReadLine());
			return userName;
		}

		public static string GetLastName()
		{
			Console.WriteLine("The Last Name is:");
			string userLast = (Console.ReadLine());
			if (userLast != null)
			{
				return userLast;
			}
			else
			{
				Console.WriteLine("Last Name cannot be empty");
				return null;
			}
		}

		public static int GetAge()
		{
			Console.WriteLine("The Age is:");
			var age = Int32.Parse(Console.ReadLine());
			if (age > 0)
			{
				return age;
			}
			else
			{
				Console.WriteLine("Incorrect age");
				return 0;
			}

		}
	}
}
