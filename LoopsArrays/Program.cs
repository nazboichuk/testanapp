using System;
using System.Linq;

namespace LoopsArrays
{
	class Program
	{
        // HW - 1_1
        //public static int CalcFactorialUsingRecursion(int n)
        //{
        //	if (n <= 1)
        //	{
        //		return 1;
        //	}

        //	return n * CalcFactorialUsingRecursion(n - 1);
        //}

        public static int CalcFactorialUsingRecursion(int n)
        {
			int result;
			result = 1;
			for (int i = 1; i <= n; i++)
			{
				result = result * i;
				return result;
			}

			return n * CalcFactorialUsingRecursion(n - 1);
        }


        static void Main(string[] args)
		{
			// HW1
			Console.WriteLine("FActorial 8: " + CalcFactorialUsingRecursion(8));

			// HW2 задача 2 порахувати к-ість парних числа в масиві даних
			for (int i = 0; i <= 40; i++)
			{
				if (i % 2 == 0)
				{
					Console.Write("{0} ", i);
				}
			}
			Console.ReadKey();
			return 0;

            // Console.WriteLine(input.Count(i => char.IsDigit(i)));

            // HW3
            var arr = "1Test78Ok".ToCharArray();
            Char.IsDigit(arr[0]);

            Console.WriteLine(GetLastItemFromArray(1, 2, 3, 4, 5, 7, 15));
        }

        // Params theory
        public static int GetLastItemFromArray(params int[] arr)
        {
            return arr[arr.Length - 1];
        }
    }
	//bool[] boolArr = { true, false, true, false };
	//int[] intArr = new int[3];
	//long[] longArr = new long[3] { 1, 2, 3 };
	//byte[] byteArr = new byte[] { 1, 2, 3 };

	//var l = boolArr.Length; //return number of items in the array
	//Array.Reverse(longArr); //change order of elements in reverse order
	//Array.Clear(byteArr, 0, byteArr.Length); //set items value to default in a range (0 for int, long, etc.; false for bool, null for strings)
}
}
