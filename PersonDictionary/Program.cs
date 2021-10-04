using System;
using System.Collections.Generic;

namespace PersonDictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> numberNames = new Dictionary<int, string>();

			// Add to Dictionary from Console 3 pairs (ID, Name) of some persons.
			for (int i = 1; i < 4; i++)
			{ 
				Console.WriteLine("Enter the Name" + i + ": ");
				string Name = Console.ReadLine();
				numberNames.Add(i, Name);
			}

			foreach (var item in numberNames)
			{
				Console.WriteLine("ID : " + item.Key);
				Console.WriteLine("Name : " + item.Value);
			}

			// Ask user to enter ID, then find and write corresponding Name from your Dictionary. If you can't find this ID - say about it to user.
			Console.WriteLine("Press key to start the search by ID:");
			int ID = int.Parse(Console.ReadLine());
			try
			{
				numberNames.ContainsKey(ID);
				Console.WriteLine("Values is: " + numberNames[ID].ToString());
			}

			catch (Exception ex)
			{
				throw new Exception("Key is not present ex!" + ex.Message, ex);
			}

			finally
			{
				Console.WriteLine("Done!");
			}
		}
	}
}
