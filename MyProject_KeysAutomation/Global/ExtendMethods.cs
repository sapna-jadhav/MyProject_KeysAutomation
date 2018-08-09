using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyProject_KeysAutomation.Global
{
	public static class ExtendMethods
	{

		public static void TextBox(IWebDriver driver, string LocatorType, string LocatorValue, string Text)
		{
			if (LocatorType == "Id")
			{
				driver.FindElement(By.Id(LocatorValue)).SendKeys(Text);
			}
			if (LocatorType == "XPath")
			{
				driver.FindElement(By.XPath(LocatorValue)).SendKeys(Text);
			}
		}

		//button click function
		public static void ButtonClick(IWebDriver driver, string LocatorType, string LocatorValue)
		{
			if (LocatorType == "Id")
			{
				driver.FindElement(By.Id(LocatorValue)).Click();
			}
			if (LocatorType == "XPath")
			{
				driver.FindElement(By.XPath(LocatorValue)).Click();
			}
		}

		//select element from dropdown

		public static void DropDown(IWebDriver driver, string LocatorType, string LocatorValue, string TextValue)
		{
			if (LocatorType == "Id")
			{
				SelectElement option = new SelectElement(driver.FindElement(By.Id(LocatorValue)));
				option.SelectByText(TextValue);
				option.SelectedOption.Click();
			}
			else if (LocatorType == "XPath")
			{
				SelectElement option = new SelectElement(driver.FindElement(By.XPath(LocatorValue)));
				option.SelectByText(TextValue);
				option.SelectedOption.Click();
			}
		}

		//clear textbox

		public static void ClearText(IWebDriver driver, string LocatorType, string LocatorValue)
		{
			if (LocatorType == "Id")
			{
				driver.FindElement(By.Id(LocatorValue)).Clear();
			}
			else if (LocatorType == "XPath")
			{
				driver.FindElement(By.XPath(LocatorValue)).Clear();
			}

		}

		//Displayed
		public static bool IsElementDisplayed(this IWebDriver driver, By element)
		{
			if (driver.FindElements(element).Count > 0)
			{
				if (driver.FindElement(element).Displayed)
					return true;
				else
					return false;
			}
			else
			{
				return false;
			}
		}

		//Enabled
		public static bool IsElementEnabled(this IWebDriver driver, By element)
		{
			if (driver.FindElements(element).Count > 0)
			{
				if (driver.FindElement(element).Enabled)
					return true;
				else
					return false;
			}
			else
			{
				return false;
			}
		}
		//The Property Name field must be between 4-30 alphanumeric characters.
		public static void IsAlphaNumeric(String strToCheck)
		{
			Regex objAlphaNumericPattern = new Regex("^[a-z A-Z 0-9_]{4,30}$");
			Assert.False(!objAlphaNumericPattern.IsMatch(strToCheck));

		}
		//The Street field Must be between 1-100 characters and cannot start with number.

		public static void ValidateStreet(String strToCheck)
		{
			Regex objAlphaNumericPattern12 = new Regex("^[^0-9] [a-z A-Z 0-9_]{1,100}$");
			Assert.IsTrue(!objAlphaNumericPattern12.IsMatch(strToCheck));

		}
		//The post code field must be numeric between 1-4 characters.
		public static void ValidatePostCode(String strToCheck)
		{
			Regex objAlphaNumericPattern = new Regex("^[1-9]{1,4}$");
			Assert.IsTrue(!objAlphaNumericPattern.IsMatch(strToCheck));

		}
		//This field must be a number from 0 to 99.

		public static void ValidateNumeric(String strToCheck)
		{
			Regex objAlphaNumericPattern = new Regex("^[0-9]{1,99}$");
			Assert.IsTrue(!objAlphaNumericPattern.IsMatch(strToCheck));

		}
		public static void ValidateTitle(string expectedTitle, string actualTitle, string successMessage, string failMessage)
		{
			try
			{
				Assert.AreEqual(expectedTitle, actualTitle);
				Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, successMessage);
			}
			catch (Exception)
			{
				Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, failMessage);
			}

		}
		public static void ValidYear(int minYear, string inputYear, string fieldName)
		{
			int currentYear = DateTime.Now.Year;
			int _inputYear = Int32.Parse(inputYear);
			try
			{

				Assert.GreaterOrEqual(_inputYear, minYear);
				Assert.LessOrEqual(_inputYear, currentYear);

				//CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Skip, passMessage);
			}
			catch (Exception ex)
			{
				//CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, failMessage);
				Console.WriteLine("The exception message : " + ex + "Inner Exception : " + ex.InnerException);
				Console.WriteLine("The Year built should be within " + minYear + " and " + currentYear);
				Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "The Year in " + fieldName + " field should be within " + minYear + " and " + currentYear);
				Driver.driver.Close();
			}

		}
	}
}
