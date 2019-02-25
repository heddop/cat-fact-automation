using NUnit.Framework;
using catProject.Driver;
using catProject.Functions;
using catProject.PageObjects;
using System.Configuration;

namespace catProject.SetUp

{
	[TestFixture]
	public class BaseSetup : SelectActions
	{
		public HomePage Homepage;

		[SetUp]
		public void Start()
		{
			var chromeWebDriver = new ChromeWebDriver();

			Driver = chromeWebDriver.GetChromeDriver();
			Homepage = new HomePage(Driver);

			var url = ConfigurationManager.AppSettings["url"];
			Driver.Navigate().GoToUrl(url); Wait();
		}

		[TearDown]
		public void End()
		{
			Driver.Close();
		}
	}
}
