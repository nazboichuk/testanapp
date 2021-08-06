using System;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			// Change the values 
			var myLaptop = new Laptop();
			myLaptop.ChangeLaptopParts(64, 2);
			myLaptop.ChangeLaptopType("Acer", "Aspire");

			
			// Change the GPU of the videocard
			// var myGpu = new GPU();
			// myGpu.gpuRam = 16;

			// Change the frequency of the CPU
			// var myCpu = new CPU();
			// myCpu.cpuFrequency = 2.4;
			
			myLaptop.ViewLaptopInfo();
			//Console.WriteLine(myCpu.GetInfoCpu());
			//Console.WriteLine(myGpu.GetInfoGpu());
		}
	}
}
