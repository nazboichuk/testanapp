using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	public struct GPU
	{
		public int gpuRam;

		public string GetInfoGpu()
		{
			return $"We have the {gpuRam} RAM of the videocard in the laptop.";
		}
	}

	public struct CPU
	{
		public double cpuFrequency;

		public string GetInfoCpu()
		{
			return $"We have the {cpuFrequency} processor frequency in the laptop.";
		}
	}
	
	public class Laptop
	{
		public string manufacturer;
		public string model;
		public int ram;
		public int hdd;
		public CPU cpuFrequency;
		public GPU gpuRam;

		public Laptop()
		{
		}

		public Laptop(int ram, int hdd)
		{
			this.ram = ram;
			this.hdd = hdd;
		}
		
		public Laptop(string manufacturer, string model)
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

		public void ViewLaptopInfo()
		{
			Console.WriteLine($"The RAM is {ram}, GB and the hard drive is {hdd} TB.");
			Console.WriteLine($"The brand is {manufacturer}, and model is {model}.");
			Console.WriteLine($"The frequency of the CPU is {cpuFrequency}, and memory for the graphics card is {gpuRam} GB.");
		}

	}
}
