using MyProject_KeysAutomation.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject_KeysAutomation.Pages
{
	class MarketPlace
	{

		public static void SS_ApplyJob()
		{
			//ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html/body/div[5]/div/div[5]/a[1]");
			Thread.Sleep(1500);
			ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/div[2]/a[3]");
			ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html[1]/body[1]/div[2]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/div[1]/button[1]");
			//Console.WriteLine(Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[2]/form[1]/fieldset[1]/div[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/h4[1]")).Text);
			Thread.Sleep(1500);
			ExtendMethods.TextBox(Driver.driver, "XPath", "/html[1]/body[1]/div[2]/div[1]/div[2]/form[1]/fieldset[1]/div[3]/div[1]/div[1]/input[1]","550");
			ExtendMethods.TextBox(Driver.driver, "XPath", "/html[1]/body[1]/div[2]/div[1]/div[2]/form[1]/fieldset[1]/div[3]/div[2]/div[1]/textarea[1]","I Will Fix This Jon ASAP");
			Thread.Sleep(1500);
			ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html[1]/body[1]/div[2]/div[1]/div[2]/form[1]/fieldset[1]/div[3]/div[4]/button[1]");
			Base.test = Base.extent.StartTest("Quote submitted successfully");



		}
	}
}
