using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using System.Threading;
using System;

namespace Scenario
{
	[TestClass]
	public class Scenario : CalculatorSession
	{
		private static WindowsElement header;
		private static WindowsElement calculatorResult;

		[DataTestMethod]



		[ClassInitialize]
		public static void ClassInitialize(TestContext context)
		{
			// Create session to launch a Calculator window
			Setup(context);

			// Identify calculator mode by locating the header
			try
			{
				header = session.FindElementByAccessibilityId("Header");
			}
			catch
			{
				header = session.FindElementByAccessibilityId("ContentPresenter");
			}

			// Ensure that calculator is in standard mode
			if (!header.Text.Equals("Standard", StringComparison.OrdinalIgnoreCase))
			{
				session.FindElementByAccessibilityId("TogglePaneButton").Click();
				Thread.Sleep(TimeSpan.FromSeconds(1));
				var splitViewPane = session.FindElementByClassName("SplitViewPane");
				splitViewPane.FindElementByName("Standard Calculator").Click();
				Thread.Sleep(TimeSpan.FromSeconds(1));
				Assert.IsTrue(header.Text.Equals("Standard", StringComparison.OrdinalIgnoreCase));
			}

			// Locate the calculatorResult element
			calculatorResult = session.FindElementByAccessibilityId("CalculatorResults");
			Assert.IsNotNull(calculatorResult);
		}

		[ClassCleanup]
		public static void ClassCleanup()
		{
			TearDown();
		}

		[TestInitialize]
		public void Clear()
		{
			session.FindElementByName("Clear").Click();
			Assert.AreEqual("0", GetCalculatorResultText());
		}

		private string GetCalculatorResultText()
		{
			return calculatorResult.Text.Replace("Display is", string.Empty).Trim();
		}
	}
}
