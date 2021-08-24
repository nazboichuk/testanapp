using System;

namespace OOP.LaptopParameters
{
  public class Properties
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
	}
}
