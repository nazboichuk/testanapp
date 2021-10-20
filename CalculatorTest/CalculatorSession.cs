using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;

namespace CalculatorTest
{
	public class CalculatorSession
	{
		protected static WindowsDriver<WindowsElement> session;

		public static void Setup()
		{
			if (session == null)
			{
				DesiredCapabilities appCapabilities = new DesiredCapabilities();
				appCapabilities.SetCapability("app", Config.CalculatorAppId);
				appCapabilities.SetCapability("deviceName", "WindowsPC");
				session = new WindowsDriver<WindowsElement>(new Uri(Config.WindowsApplicationDriverUrl), appCapabilities);
				Assert.IsNotNull(session);

				// Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
				session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Config.ImplicitTimeout);
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