using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_KeysAutomation.Global
{
	class Driver
	{
		public static IWebDriver driver { get; set; }

		

		public static void Wait(int time)
		{
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);

		}
		public static IWebElement WaitForElement(IWebDriver driver, By by, int timeOutinSeconds)
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));


#pragma warning disable CS0618 // Type or member is obsolete
			return (wait.Until(ExpectedConditions.ElementIsVisible(by)));
#pragma warning restore CS0618 // Type or member is obsolete

		}
	}
}
