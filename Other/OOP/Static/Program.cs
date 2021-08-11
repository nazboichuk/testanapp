using System;
using static System.Console;

namespace Static
{
	class Program
	{
		static void Main(string[] args)
		{
			var userPerson = new Person();
			userPerson.userName = GetUserInfo.GetFirstName();
			userPerson.userLastName = GetUserInfo.GetLastName();
			userPerson.userAge = GetUserInfo.GetAge();
		}
	}
}
