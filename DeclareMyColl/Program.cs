using System;
using System.Collections.Generic;

namespace DeclareMyColl
{
	class Program
	{
		static void PrintList<T>(List<T> list)
		{
			Console.WriteLine(string.Join(" ", list));
		}

		static void Main(string[] args)
		{
			List<int> myColl = new List<int>() { 25, 0, 10, 7, 27, 3, 5, 12 };

			// 1) Find and print all positions of element - 10 in the collection
			PrintList(myColl);

			// 2) Remove from collection elements, which are greater then 10, Print collection
			for (int i = 0; i < myColl.Count; i++)
			{
				if (myColl[i] > 10)
				{
					myColl.RemoveAt(i);
					i--;
				}
			}

			PrintList(myColl);

			// 3) Insert elements 1, 4, 3 in positions 2, 5, 1. Print collection
			myColl.Insert(2, 1);
			myColl.Insert(5, 4);
			myColl.Insert(1, 3);

			PrintList(myColl);

			// 4) Sort and print collection
			myColl.Sort();

			PrintList(myColl);
		}
	}
}
