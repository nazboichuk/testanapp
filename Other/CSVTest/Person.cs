using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public override string ToString()
		{
			return $"Name of the person is: {this.Name}; and age: {this.Age}";
		}
	}
}
