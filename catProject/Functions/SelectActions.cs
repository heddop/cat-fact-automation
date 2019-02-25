using OpenQA.Selenium;
using System.Threading;

namespace catProject.Functions
{
	public class SelectActions
	{
		public IWebDriver Driver;

		public void Wait()
		{
			Thread.Sleep(1000);
		}

		public void WaitLonger()
		{
			Thread.Sleep(5000);
		}

		public void EnterDataInField(string input, IWebElement element)
		{
			element.Click(); Wait();
			element.Clear(); Wait();
			element.SendKeys(input); 
			
		}
	}
}
