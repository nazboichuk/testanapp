using OpenQA.Selenium.Appium.Windows;
using System.Threading;
using System;
using NUnit.Framework;

namespace CalculatorTest
{
	public class ScenarioStandard : CalculatorSession
	{
		private static WindowsElement header;
		private static WindowsElement calculatorResult;
		private static CalculatorPage calculator;

		[Test]
		public void Addition()
		{
			// Find the buttons by their names and click them in sequence to perform 2 + 7 = 9
			calculator.ClickButtonTwo();
			calculator.ClickButtonPlus();
			calculator.ClickButtonSeven();
			calculator.ClickButtonEquals();
			Assert.AreEqual("9", GetCalculatorResultText());
		}

		[Test]
		public void Division()
		{
			// Find the buttons by their accessibility ids and click them in sequence to perform 88 / 11 = 8
			calculator.ClickButtonEight();
			calculator.ClickButtonEight();
			calculator.ClickButtonDivide();
			calculator.ClickButtonOne();
			calculator.ClickButtonOne();
			calculator.ClickButtonEquals();
			Assert.AreEqual("8", GetCalculatorResultText());
		}

		[Test]
		public void Multiplication()
		{
			// Find the buttons by their names using XPath and click them in sequence to perform 9 x 9 = 81
			calculator.ClickButtonNine();
			calculator.ClickButtonMultiply();
			calculator.ClickButtonNine();
			calculator.ClickButtonEquals();
			Assert.AreEqual("81", GetCalculatorResultText());
		}

		[Test]
		public void Subtraction()
		{
			// Find the buttons by their accessibility ids using XPath and click them in sequence to perform 9 - 1 = 8
			calculator.ClickButtonNine();
			calculator.ClickButtonMinus();
			calculator.ClickButtonOne();
			calculator.ClickButtonEquals();
			Assert.AreEqual("8", GetCalculatorResultText());
		}


		[OneTimeSetUp]
		public static void ClassInitialize()
		{
			// Create session to launch a Calculator window
			Setup();
			calculator = new CalculatorPage(session);
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

		[OneTimeTearDown]
		public static void ClassCleanup()
		{
			TearDown();
		}

		[SetUp]
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
