using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTasksWithLoopsAndConditions
{
	public class AgeCalculator
	{
		// HW 5
		// I have a cat and a dog.
		// I got them at the same time as kitten / puppy. That was humanYears years ago.
		// Return their respective ages now as [humanYears, catYears, dogYears]
		// NOTES:
		// humanYears >= 1humanYears are whole numbers only
		// Cat Years
		// 15 cat years for first year; +9 cat years for second year; +4 cat years for each year after that 
		// Dog Years
		// 15 dog years for first year; +9 dog years for second year; +5 dog years for each year after that
		public int[] CalcYears(int humanYears)
		{
			int catAge = 15;
			int dogAge = 15;

			for (int year = 2; year <= humanYears; year++)
			{
				if (year == 2)
				{
					catAge += 9;
					dogAge += 9;
				}
				else
				{
					catAge += 4;
					dogAge += 5;
				}
			}

			return new int[] { humanYears, catAge, dogAge };
		}
	}
}
