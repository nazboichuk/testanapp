using System;

namespace OOP
{
	class Program
	{
//Структури процесора і відеокарти мають мати поля з їх назвами та основними характеристиками(для процесора - частота, для відеокарти - пам'ять)
//Крім цього в обох структурах має бути метод, що повертає інфу про екземпляр (у вигляді тексту)
//В класі Laptop мають бути 2-3 конструктори, та методи, що дозволяють змінювати комплектуючі(відеокарту, процесор)
		static void Main(string[] args)
		{
			var myLaptop = new Laptop();
			myLaptop.ChangeLaptopParts(64, 2);
			myLaptop.ChangeLaptopType("Acer", "Aspire");

			var myGpu = new GPU();
			myGpu.GpuRam = 16;

			var myCpu = new CPU();
			myCpu.CpuFrequency = 2.4;

			myLaptop.ViewLaptopInfo();
			Console.WriteLine(myCpu.GetInfoCpu());
			Console.WriteLine(myGpu.GetInfoGpu());
		}
	}
}
