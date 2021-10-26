using OpenQA.Selenium.Appium.Windows;
using System.Threading;
using System;
using NUnit.Framework;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using Allure.Commons;

namespace CalculatorTest
{
	[AllureNUnit]

	public class ScenarioStandard : CalculatorSession
	{
		private static WindowsElement header;
		private static WindowsElement calculatorResult;
		private static CalculatorPage calculator;

		[Test, TestCase("9")]
		[AllureTag("Regression")]
		[AllureSeverity(SeverityLevel.critical)]
		[AllureIssue("ISSUE-1")]
		[AllureTms("TMS-12")]
		[AllureOwner("User")]
		[AllureSuite("PassedSuite")]
		[AllureSubSuite("NoAssert")]
		public void Addition(string expectedResult)
		{
			calculator.ClickButtonTwo();
			calculator.ClickButtonPlus();
			calculator.ClickButtonSeven();
			calculator.ClickButtonEquals();
			Assert.AreEqual(expectedResult, GetCalculatorResultText());
		}

		[Test, TestCase("8")]
		[AllureTag("Regression")]
		[AllureSeverity(SeverityLevel.critical)]
		[AllureIssue("ISSUE-1")]
		[AllureTms("TMS-12")]
		[AllureOwner("User")]
		[AllureSuite("PassedSuite")]
		[AllureSubSuite("NoAssert")]
		public void Division(string expectedResult)
		{
			calculator.ClickButtonEight();
			calculator.ClickButtonEight();
			calculator.ClickButtonDivide();
			calculator.ClickButtonOne();
			calculator.ClickButtonOne();
			calculator.ClickButtonEquals();
			Assert.AreEqual(expectedResult, GetCalculatorResultText());
		}

		[Test, TestCase("81")]
		[AllureTag("Regression")]
		[AllureSeverity(SeverityLevel.critical)]
		[AllureIssue("ISSUE-1")]
		[AllureTms("TMS-12")]
		[AllureOwner("User")]
		[AllureSuite("PassedSuite")]
		[AllureSubSuite("NoAssert")]
		public void Multiplication(string expectedResult)
		{
			calculator.ClickButtonNine();
			calculator.ClickButtonMultiply();
			calculator.ClickButtonNine();
			calculator.ClickButtonEquals();
			Assert.AreEqual(expectedResult, GetCalculatorResultText());
		}

		[Test, TestCase("8")]
		[AllureTag("Regression")]
		[AllureSeverity(SeverityLevel.normal)]
		[AllureOwner("User")]
		[AllureSuite("PassedSuite")]
		[AllureSubSuite("NoAssert")]
		public void Subtraction(string expectedResult)
		{
			calculator.ClickButtonNine();
			calculator.ClickButtonMinus();
			calculator.ClickButtonOne();
			calculator.ClickButtonEquals();
			Assert.AreEqual(expectedResult, GetCalculatorResultText());
		}

		[OneTimeSetUp]
		public static void ClassInitialize()
		{
			// Create session to launch a Calculator window
			Setup();
			calculator = CalculatorPage.GetInstance(session);

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
