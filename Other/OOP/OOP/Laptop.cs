﻿using System;
using static OOP.LaptopParameters.Properties;

namespace OOP
{
	public class Laptop
	{
		private int laptopTemperature = 50;
		public int Temperature { get { return laptopTemperature; } }

		public string Manufacturer;
		public string Model;
		public int RAM;
		public int HDD;
		public CPU CPU;
		public GPU GPU;

		public Laptop()
		{
		}

		public Laptop(int ram)
		{
			RAM = ram;
		}

		public Laptop(int ram, int hdd) : this(ram)
		{
			HDD = hdd;
		}

		public Laptop(int ram, int hdd, double cpuFreq) : this(ram, hdd)
		{
			CPU.CpuFrequency = cpuFreq;
		}

		public Laptop(int ram, int hdd, double cpuFreq, int gpuRam) : this(ram, hdd, cpuFreq)
		{
			GPU.GpuRam = gpuRam;
		}

		public Laptop(int ram, int hdd, double cpuFreq, int gpuRam, string manufacturer) : this(ram, hdd, cpuFreq, gpuRam)
		{
			Manufacturer = manufacturer;
		}

		public Laptop(int ram, int hdd, double cpuFreq, int gpuRam, string manufacturer, string model) : this(ram, hdd, cpuFreq, gpuRam, manufacturer)
		{
			Model = model;
		}


		public Laptop ChangeLaptopType(string manufacturer, string model)
		{
			Manufacturer = manufacturer;
			Model = model;
			return this;
		}

		public Laptop ChangeLaptopParts(int ram, int hdd)
		{
			RAM = ram;
			HDD = hdd;
			return this;
		}

		public void DoSomeWrok()
		{
			if (Temperature == 50)
			{
				Console.WriteLine($"Current laptop is working and turned on.");
			}
			else
			{
				Console.WriteLine($"No power!");
			}
		}

		public void ViewLaptopInfo()
		{
			Console.WriteLine($"The RAM is {RAM}, GB and the hard drive is {HDD} TB.");
			Console.WriteLine($"The brand is {Manufacturer}, and model is {Model}.");
			Console.WriteLine($"The frequency of the CPU is {CPU.CpuFrequency}, and memory for the graphics card is {GPU.GpuRam} GB.");
		}

	}
}
