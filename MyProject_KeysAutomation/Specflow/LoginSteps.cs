using MyProject_KeysAutomation.Global;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MyProject_KeysAutomation
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I have logged in home page with valid Owner")]
        public void GivenIHaveLoggedInHomePageWithValidOwner()
        {
			Base.Init();

			LoginPage obj = new LoginPage();
			obj.MyDoSomethingMethod(LoginPage.MyEnumUserLogin.PropertyOwner);

		}
        
        [Given(@"I have logged in with valid Service Supplier")]
        public void GivenIHaveLoggedInWithValidServiceSupplier()
        {
			Base.Init();
			LoginPage obj = new LoginPage();
			obj.MyDoSomethingMethod(LoginPage.MyEnumUserLogin.Service_Supp);
			ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html/body/div[5]/div/div[5]/a[1]");
		}
        
        [When(@"I try to add new job")]
        public void WhenITryToAddNewJob()
        {
			
			Pages.PO_Advertise_Job_Quotes.PO_AdvertiseJobs();
			


		}
        
        [When(@"I try to apply for new job")]
        public void WhenITryToApplyForNewJob()
        {
			Pages.MarketPlace.SS_ApplyJob();
			SignOut.SignOutFromPage();
		}
        
        [Then(@"the job gets added")]
        public void ThenTheJobGetsAdded()
        {
			var ScreenshotPath = ExcelData.SaveScreenshot(Driver.driver, "Job Added successfully", Global.Base.ScreenshotPath);
			Thread.Sleep(1500);
			Driver.driver.Quit();
		}

		[Then(@"I can successfully apply for the jo")]
        public void ThenICanSuccessfullyApplyForTheJo()
        {
			var ScreenshotPath = ExcelData.SaveScreenshot(Driver.driver, "Quote Submitted successfully", Global.Base.ScreenshotPath);
			Thread.Sleep(1500);
			Driver.driver.Quit();
		}
	}
}
