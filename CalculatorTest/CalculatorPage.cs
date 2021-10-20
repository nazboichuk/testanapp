using OpenQA.Selenium.Appium.Windows;

namespace CalculatorTest
{
	public class CalculatorPage
	{
		private WindowsDriver<WindowsElement> driver;

		public CalculatorPage(WindowsDriver<WindowsElement> driver)
		{
			this.driver = driver;
		}

		private WindowsElement ButtonTwo => driver.FindElementByName("Two");
		private WindowsElement ButtonPlus => driver.FindElementByName("Plus");
		private WindowsElement ButtonSeven => driver.FindElementByName("Seven");
		private WindowsElement ButtonEquals => driver.FindElementByName("Equals");
		private WindowsElement ButtonEight => driver.FindElementByAccessibilityId("num8Button");
		private WindowsElement ButtonDivide => driver.FindElementByAccessibilityId("divideButton");
		private WindowsElement ButtonOne => driver.FindElementByAccessibilityId("num1Button");
		private WindowsElement ButtonNine => driver.FindElementByXPath("//Button[@Name='Nine']");
		private WindowsElement ButtonMultiply => driver.FindElementByXPath("//Button[@Name='Multiply by']");
		private WindowsElement ButtonMinus => driver.FindElementByXPath("//Button[@AutomationId=\"minusButton\"]");
		//private WindowsElement calculatorResult;

		public CalculatorPage ClickButtonTwo()
		{
			ButtonTwo.Click();
			return this;
		}

		public CalculatorPage ClickButtonPlus()
		{
			ButtonPlus.Click();
			return this;
		}

		public CalculatorPage ClickButtonSeven()
		{
			ButtonSeven.Click();
			return this;
		}

		public CalculatorPage ClickButtonEquals()
		{
			ButtonEquals.Click();
			return this;
		}

		public CalculatorPage ClickButtonEight()
		{
			ButtonEight.Click();
			return this;
		}

		public CalculatorPage ClickButtonDivide()
		{
			ButtonDivide.Click();
			return this;
		}

		public CalculatorPage ClickButtonOne()
		{
			ButtonOne.Click();
			return this;
		}

		public CalculatorPage ClickButtonNine()
		{
			ButtonNine.Click();
			return this;
		}

		public CalculatorPage ClickButtonMultiply()
		{
			ButtonMultiply.Click();
			return this;
		}

		public CalculatorPage ClickButtonMinus()
		{
			ButtonMinus.Click();
			return this;
		}

		//public string GetCalculatorResultText()
		//{
		//	return calculatorResult.Text.Replace("Display is", string.Empty).Trim();
		//}
	}
}
