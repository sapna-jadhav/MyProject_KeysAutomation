using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_KeysAutomation.Global
{
	class LoginPage:Base
	{
		public static IWebDriver myDriver = Global.Driver.driver;

		public enum MyEnumUserLogin
		{
			 PropertyOwner = 1, Service_Supp = 2, Tenant = 3

		}
		

		public void MyDoSomethingMethod(MyEnumUserLogin userLogin)
		{
			switch (userLogin)
			{
				

				case MyEnumUserLogin.PropertyOwner:
					
					break;
				case MyEnumUserLogin.Service_Supp:
					
					break;
				case MyEnumUserLogin.Tenant:

					break;
			}

			
			if (userLogin == MyEnumUserLogin.PropertyOwner)
			{
				// Finding the excel path for data driven input
				Global.ExcelData.PopulateInCollection(Base.ExcelPath, "Login");

				//passing the url
				myDriver.Navigate().GoToUrl(Global.ExcelData.ReadData(2, "Url"));

				//Passing username and password
				Global.ExtendMethods.TextBox(myDriver, "XPath", "//*[@id='UserName']", Global.ExcelData.ReadData(2, "UserName"));
				Global.ExtendMethods.TextBox(myDriver, "Id", "Password", Global.ExcelData.ReadData(2, "Password"));

				//clicking the signin button
				Global.ExtendMethods.ButtonClick(myDriver, "XPath", "//*[@id='sign_in']/div[1]/div[4]/button");

			}

			if (userLogin == MyEnumUserLogin.Tenant)
			{
				Global.ExcelData.PopulateInCollection(Base.ExcelPath, "Login");

				//passing the url
				myDriver.Navigate().GoToUrl(Global.ExcelData.ReadData(3, "Url"));

				//Passing username and password
				Global.ExtendMethods.TextBox(myDriver, "XPath", "//*[@id='UserName']", Global.ExcelData.ReadData(5, "UserName"));
				Global.ExtendMethods.TextBox(myDriver, "Id", "Password", Global.ExcelData.ReadData(5, "Password"));

				//clicking the signin button
				Global.ExtendMethods.ButtonClick(myDriver, "XPath", "//*[@id='sign_in']/div[1]/div[4]/button");

			}
			if (userLogin == MyEnumUserLogin.Service_Supp)
			{
				Global.ExcelData.PopulateInCollection(Base.ExcelPath, "Login");

				//passing the url
				myDriver.Navigate().GoToUrl(Global.ExcelData.ReadData(3, "Url"));

				//Passing username and password
				Global.ExtendMethods.TextBox(myDriver, "XPath", "//*[@id='UserName']", Global.ExcelData.ReadData(5, "UserName"));
				Global.ExtendMethods.TextBox(myDriver, "Id", "Password", Global.ExcelData.ReadData(5, "Password"));

				//clicking the signin button
				Global.ExtendMethods.ButtonClick(myDriver, "XPath", "//*[@id='sign_in']/div[1]/div[4]/button");

			}

		}

			

	}
}

