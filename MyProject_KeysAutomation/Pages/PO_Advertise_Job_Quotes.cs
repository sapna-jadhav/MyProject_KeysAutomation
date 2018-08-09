using MyProject_KeysAutomation.Global;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject_KeysAutomation.Pages
{
	class PO_Advertise_Job_Quotes
	{
		public static void PO_AdvertiseJobs()
		{
			ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html/body/div[5]/div/div[5]/a[1]");
			Thread.Sleep(1500);

			//navigate to Owners>Properties
			ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]");
			Thread.Sleep(1500);
			ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/div[1]/a[4]");

			
			//Checking the right page
			Assert.AreEqual("My Advertised Jobs", Driver.driver.Title);
			Base.test = Base.extent.StartTest("In My Advertised Jobs  page");
			Thread.Sleep(1500);

			//Adding new job
			ExtendMethods.ButtonClick(Driver.driver, "XPath", "/ html[1] / body[1] / div[2] / div[1] / div[1] / div[2] / div[1] / div[2] / a[1]");
			

			ExtendMethods.TextBox(Driver.driver, "XPath", "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[2]/div[1]/input[1]", "Gas Geyser Installation");
			Thread.Sleep(1500);
			ExtendMethods.TextBox(Driver.driver, "XPath", "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[3]/div[1]/input[1]", "600");
			Thread.Sleep(1500);

			ExtendMethods.TextBox(Driver.driver, "XPath", "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/textarea[1]", "Need Urgent installation of gas geyser");
			ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/div[1]/div[3]/div[1]/div[1]/button[1]");
			Base.test = Base.extent.StartTest("Job added succesfully");
		}

	}
}
