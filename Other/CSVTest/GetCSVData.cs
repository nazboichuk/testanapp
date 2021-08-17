using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;
using PersonProperties;

namespace GetCsvData
{
	public static class PersonCsvHelper
	{
		public static void PersonData()
		{
				Person person = new Person();
			using (var reader = new StreamReader(@"C:\Users\nboichuk\Documents\GitHub\testanapp\Other\CSVTest\data\file.csv"))
			{
					using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
					{
						var result = csv.GetRecords<Person>();
						person = result.First();
					}
				}
			Console.WriteLine($"1-st sell is: {person.FirstName}, next one is: {person.LastName}, and age is: {person.Age}");
			Console.ReadKey();
		}
	}
}
