using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;

namespace AutomateCalculator
{
	public class CalculatorSession
	{
		private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
		private const string CalculatorAppId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

		protected static WindowsDriver<WindowsElement> session;

		public static void Setup(TestContext context)
		{
			if (session == null)
			{
				DesiredCapabilities appCapabilities = new DesiredCapabilities();
				appCapabilities.SetCapability("app", CalculatorAppId);
				appCapabilities.SetCapability("deviceName", "WindowsPC");
				session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
				Assert.IsNotNull(session);

				// Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
				session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
			}
		}

		public static void TearDown()
		{
			if (session != null)
			{
				session.Quit();
				session = null;
			}
		}
	}
}
