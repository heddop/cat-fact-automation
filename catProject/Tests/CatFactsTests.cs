using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using catProject.SetUp;
using catProject.Helpers;

namespace catProject
{
	[TestFixture]
	public class CatFactsTests : BaseSetup
	{
		private string _username;
		private string _password;

		public CatFactsTests()
		{
			var encodedUsername = ConfigurationManager.AppSettings["username"];
			var encodedPassword = ConfigurationManager.AppSettings["password"];

			var base64Decoder = new Base64Decoder();
			_username = base64Decoder.DecodeBase64String(encodedUsername);
			_password = base64Decoder.DecodeBase64String(encodedPassword);
		}

		[TestCase]
		public void CatFactTest()
		{
			Homepage.btn6.Click(); Wait();
			Homepage.btnSignIn.Click(); Wait();
			EnterDataInField(_username, Homepage.userName); Wait();
			Homepage.usernameNext.Click(); Wait();
			EnterDataInField(_password, Homepage.password); Wait();
			Homepage.password.SendKeys(Keys.Enter); WaitLonger();
			EnterDataInField("A cat lover is called an Ailurophilia (Greek: cat+lover).", Homepage.input); Wait();
			Homepage.submit.Click(); Wait();
		}
	}
}
