using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;
using Person;
using System.Collections.Generic;

namespace CsvHelpers
{
	public static class CsvHelpers
	{
		public static List<T> ReadCsvAs<T>(string path)
		{
			List<T> list = new List<T>();

			using (var reader = new StreamReader(path))
			{
					using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
					{
						var result = csv.GetRecords<T>();
						list = result.ToList();
					}
				}
			return list;
		}
	}
}
