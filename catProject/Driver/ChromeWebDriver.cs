using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace catProject.Driver
{
	public class ChromeWebDriver
	{
		public IWebDriver GetChromeDriver()
		{
			var driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			return driver;
		}
	}
}
