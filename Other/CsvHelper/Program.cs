using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;

namespace GetCsvData
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();
			using (var reader = new StreamReader(@"C:\Users\nboichuk\Documents\GitHub\testanapp\Other\CsvHelper\data\file.csv"))
			{
				using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
				{
					var result = csv.GetRecords<Person>();
					person = result.First();
				}
			}
			Console.WriteLine(person.FirstName + person.LastName + person.Age);
		}
	}
}
