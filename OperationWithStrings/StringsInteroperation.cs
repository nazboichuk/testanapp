using System;

namespace OperationWithStrings
{
	public class StringsInteroperation
	{
		public int GetStringLength(string value)
		{
			return value.Length;
		}

		public bool DoesStringContainsOtherString(string s1, string s2)
		{
			return s1.Contains(s2);
		}

		public bool DoesStringEqualsToOtherString(string s1, string s2)
		{
			return s1.Equals(s2);
		}

		public string ReplaceTheString(string oldValue, string newValue)
		{
			return newValue.Replace(oldValue, newValue);
		}

		public string RemoveTheString(string value, int index)
		{
			return value.Remove(index);
		}

		public string RemoveSpacesFromString(string value)
		{
			return value.Trim();
		}

		public string ConvertStringToUpperCase(string value)
		{
			return value.ToUpper();
		}

		public string ConvertStringToLowerCase(string value)
		{
			return value.ToLower();
		}

	}
}
