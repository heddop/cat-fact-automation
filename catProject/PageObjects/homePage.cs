using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using catProject.Functions;

namespace catProject.PageObjects
{
	public class HomePage : SelectActions
	{
		private IWebDriver _driver;

		public HomePage(IWebDriver driver)
		{
			_driver = driver;
			_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
			PageFactory.InitElements(_driver, this);
		}

		[FindsBy(How = How.Id, Using = "tab-item-6")]
		public IWebElement btn6;

		[FindsBy(How = How.Id, Using = "tab-item-5")]
		public IWebElement btn5;

		[FindsBy(How = How.LinkText, Using = "SIGN IN")]
		public IWebElement btnSignIn;

		[FindsBy(How = How.Id, Using = "identifierId")]
		public IWebElement userName;

		[FindsBy(How = How.Id, Using = "identifierNext")]
		public IWebElement usernameNext;

		[FindsBy(How = How.XPath, Using = "//input[contains(@type,'password')]")]
		public IWebElement password;

		[FindsBy(How = How.XPath, Using = "//button[contains(@type, 'submit')]")]
		public IWebElement submit;

		[FindsBy(How = How.Id, Using = "input_4")]
		public IWebElement input;



	}
}
