//using System;
//using System.Collections.Generic;
//using System.Text;
//using NUnit.Framework;
//using OpenQA.Selenium.Appium.Windows;
//using OpenQA.Selenium.Remote;
//using OpenQA.Selenium.Appium.Windows;

//namespace AllureReportExample
//{
//	class CalculatorPage
//	{
//		public class CalculatorPage
//		{
//			#region Constructor and private field 
//			private WindowsDriver<WindowsElement> driver;
//			private CalculatorPage(WindowsDriver<WindowsElement> driver)
//			{
//				this.driver = driver;
//			}

//			private static CalculatorPage _page = null;
//			public static CalculatorPage GetInstance(WindowsDriver<WindowsElement> driver)
//			{
//				if (_page == null)
//				{
//					_page = new CalculatorPage(driver);
//				}
//				return _page;
//			}
//			#endregion

//			#region Window elements
//			private WindowsElement ButtonOne => driver.FindElementByName("One");
//			private WindowsElement ButtonTwo => driver.FindElementByName("Two");
//			private WindowsElement ButtonSeven => driver.FindElementByName("Seven");
//			private WindowsElement ButtonEight => driver.FindElementByName("Eight");
//			private WindowsElement ButtonNine => driver.FindElementByName("Nine");
//			private WindowsElement ButtonDivide => driver.FindElementByName("Divide by");
//			private WindowsElement ButtonMultiply => driver.FindElementByName("Multiply by");
//			private WindowsElement ButtonPlus => driver.FindElementByName("Plus");
//			private WindowsElement ButtonMinus => driver.FindElementByName("Minus");
//			private WindowsElement ButtonEquals => driver.FindElementByName("Equals");
//			#endregion

//			#region Elements interaction
//			public CalculatorPage ClickButtonTwo()
//			{
//				ButtonTwo.Click();
//				return this;
//			}

//			public CalculatorPage ClickButtonPlus()
//			{
//				ButtonPlus.Click();
//				return this;
//			}

//			public CalculatorPage ClickButtonSeven()
//			{
//				ButtonSeven.Click();
//				return this;
//			}

//			public CalculatorPage ClickButtonEquals()
//			{
//				ButtonEquals.Click();
//				return this;
//			}

//			public CalculatorPage ClickButtonEight()
//			{
//				ButtonEight.Click();
//				return this;
//			}

//			public CalculatorPage ClickButtonDivide()
//			{
//				ButtonDivide.Click();
//				return this;
//			}

//			public CalculatorPage ClickButtonOne()
//			{
//				ButtonOne.Click();
//				return this;
//			}

//			public CalculatorPage ClickButtonNine()
//			{
//				ButtonNine.Click();
//				return this;
//			}

//			public CalculatorPage ClickButtonMultiply()
//			{
//				ButtonMultiply.Click();
//				return this;
//			}

//			public CalculatorPage ClickButtonMinus()
//			{
//				ButtonMinus.Click();
//				return this;
//			}
//			#endregion
//		}
//	}
//}
