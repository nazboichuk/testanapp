using System;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			// Change the GPU of the videocard
			var myGpu = new GPU();
			myGpu.GpuRam = 16;

			// Change the frequency of the CPU
			var myCpu = new CPU();
			myCpu.CpuFrequency = 2.4;
			
			// Change the values #1
			var myLaptop = new Laptop();
			myLaptop.ChangeLaptopParts(64, 2);
			myLaptop.ChangeLaptopType("Acer", "Aspire");
			myLaptop.Cpu = myCpu;
			myLaptop.ViewLaptopInfo();
			
			//Console.WriteLine(myCpu.GetInfoCpu());
			//Console.WriteLine(myGpu.GetInfoGpu());
		}
	}
}
