﻿using System;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			//// #1
			//var myGpu = new GPU();
			//myGpu.GpuRam = 16;
			//var myCpu = new CPU();
			//myCpu.CpuFrequency = 2.4;
			
			//var myLaptop = new Laptop();
			//myLaptop.ChangeLaptopParts(64, 2);
			//myLaptop.ChangeLaptopType("Acer", "Aspire");
			//myLaptop.CPU = myCpu;
			//myLaptop.GPU = myGpu;
			//myLaptop.ViewLaptopInfo();

			// #2
			var myLaptop2 = new Laptop(2, 2, 1.4, 512, "HP", "Pavilion");
			myLaptop2.ViewLaptopInfo();
		}
	}
}
