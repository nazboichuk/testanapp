using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	// Working with value type
	public struct GPU
	{
		public int GpuRam;

		public string GetInfoGpu()
		{
			return $"We have the {GpuRam} RAM of the videocard in the laptop.";
		}
	}

	public struct CPU
	{
		public double CpuFrequency;

		public string GetInfoCpu()
		{
			return $"We have the {CpuFrequency} processor frequency in the laptop.";
		}
	}

	// Working with reff type
	public class Laptop
	{
		public string manufacturer;
		public string model;
		public int ram;
		public int hdd;

		public Laptop() // Default contstructor
		{
		}

		public Laptop(int ram, int hdd) // Parts only
		{
			this.ram = ram;
			this.hdd = hdd;
		}

		public Laptop(string manufacturer, string model) // Brand/model only
		{
			this.manufacturer = manufacturer;
			this.model = model;
		}

		public Laptop ChangeLaptopType(string manufacturer, string model)
		{
			this.manufacturer = manufacturer;
			this.model = model;
			return this;
		}

		public Laptop ChangeLaptopParts(int ram, int hdd)
		{
			this.ram = ram;
			this.hdd = hdd;
			return this;
		}

		public void ViewLaptopInfo() // Print all changes
		{
			Console.WriteLine($"The RAM is {ram}, GB and the hard drive is {hdd} TB.");
			Console.WriteLine($"The brand is {manufacturer}, and model is {model}.");
			//Console.WriteLine($"The brand {Gp} and model is {model}");
		}

	}
}
