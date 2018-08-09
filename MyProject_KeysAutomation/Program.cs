using MyProject_KeysAutomation.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_KeysAutomation
{
	class Program:Base
	{
		//static void Main(string[] args)
		//{
		//}

		//IWebDriver driver;

		[SetUp]
		public void StartTest()
		{
			Global.Base.Init();
		}

		[Test]
		public void StartLogin()
		{

			//Login with property owner
			LoginPage obj = new LoginPage();
			obj.MyDoSomethingMethod(LoginPage.MyEnumUserLogin.PropertyOwner);
			Pages.PO_Advertise_Job_Quotes.PO_AdvertiseJobs();
			HomePage.SkipButton();
			
			//Login with service supplier
			//SignOut.SignOutFromPage();
			obj.MyDoSomethingMethod(LoginPage.MyEnumUserLogin.Service_Supp);
			Pages.MarketPlace.SS_ApplyJob();
			SignOut.SignOutFromPage();

		}
		
		[TearDown]
		public void Endtest()
		{
			Driver.driver.Quit();
		}
		
	}
}
