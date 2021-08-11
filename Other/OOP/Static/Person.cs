using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
	public class Person
	{
		public string userName;
		public string userLastName;
		public int userAge;

		public void GetUserInfo()
		{
			Console.WriteLine($"Person name is {userName}, with the last name {userLastName} and age {userAge}.");
		}
	}
}
