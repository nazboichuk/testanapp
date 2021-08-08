using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace OOP
{
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
	
	public class Laptop
	{
		public string Manufacturer;
		public string Model;
		public int Ram;
		public int Hdd;
		public CPU Cpu;
		public GPU Gpu;

		public Laptop()
		{
		}
		
		public Laptop(int ram, int hdd, double cpuFreq, int gpuRam)
		{
			Ram = ram;
			Hdd = hdd;
			Cpu.CpuFrequency = cpuFreq;
			Gpu.GpuRam = gpuRam;
		}
		
		public Laptop(string manufacturer, string model)
		{
			Manufacturer = manufacturer;
			Model = model;
		}
		
		public Laptop(int ram)
		{

		}

		public Laptop ChangeLaptopType(string manufacturer, string model)
		{
			Manufacturer = manufacturer;
			Model = model;
			return this;
		}

		public Laptop ChangeLaptopParts(int ram, int hdd)
		{
			Ram = ram;
			Hdd = hdd;
			return this;
		}

		public void ViewLaptopInfo()
		{
			Console.WriteLine($"The RAM is {Ram}, GB and the hard drive is {Hdd} TB.");
			Console.WriteLine($"The brand is {Manufacturer}, and model is {Model}.");
			Console.WriteLine($"The frequency of the CPU is {Cpu}, and memory for the graphics card is {Gpu} GB.");
		}

	}
}
