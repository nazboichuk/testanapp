using System;
using System.Collections.Generic;
using System.Text;

namespace GetCsvData
{
	[Serializable]
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
	}
}
