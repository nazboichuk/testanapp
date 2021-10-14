using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	class Car
	{
		public string Production { get; set; }
		public string Model { get; set; }

		public override string ToString()
		{
			return $"Production of the car is: {this.Production}; and Model is: {this.Model}";
		}
	}
}
