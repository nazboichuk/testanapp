using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;
using CsvHelpers;


namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			var l1 = CsvHelpers.CsvHelpers.ReadCsvAs<Person.Person>(@"C:\Users\nboichuk\Documents\GitHub\testanapp\Other\CSVTest\data\file.csv");
			var l2 = CsvHelpers.CsvHelpers.ReadCsvAs<Car.Car>(@"C:\Users\nboichuk\Documents\GitHub\testanapp\Other\CSVTest\data\file2.csv");

			Console.WriteLine("Here a list of the CSV import:");

			foreach (var item in l1)
			{
				Console.WriteLine(item);
			}

			foreach (var item in l2)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();
		}
	}
}