using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			GetCsvData.PersonCsvHelper.PersonData(@"C:\Users\nboichuk\Documents\GitHub\testanapp\Other\CSVTest\data\file.csv");
		}
	}
}