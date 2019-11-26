using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace herokuapp
{
    class HomePage
    {
        public static void ClickLinkText(IWebDriver driver, string linkText)
        {
            IWebElement Link = null;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            
            try
            {
                Link = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText(linkText)));
                Link.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("Encountered unexpected exception: " + e.Message);
            }
        }
    }
}
