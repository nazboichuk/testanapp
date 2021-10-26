//using System;
//using NUnit.Framework;
//using OpenQA.Selenium.Appium.Windows;
//using OpenQA.Selenium.Remote;

//namespace AllureReportExample
//{
//	class CalculatorSession
//	{
//		protected static WindowsDriver<WindowsElement> session;

//		public static void Setup()
//		{
//			if (session == null)
//			{
//				DesiredCapabilities appCapabilities = new DesiredCapabilities();
//				appCapabilities.SetCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
//				appCapabilities.SetCapability("deviceName", "WindowsPC");
//				session = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities);
//				Assert.IsNotNull(session);

//				// Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
//				session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
//			}
//		}

//		public static void TearDown()
//		{
//			if (session != null)
//			{
//				session.Quit();
//				session = null;
//			}
//		}
//	}
//}