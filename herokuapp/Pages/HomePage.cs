using herokuapp.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using static herokuapp.Enums;

namespace herokuapp
{
    class HomePage
    {
        public static bool ClickLinkText(IWebDriver driver, HomePageLinks linkText)
        {
            Logger.log.Info("Start.");
            bool IsSuccessful = false;
            IWebElement Link = null;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            
            try
            {
                Link = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText(GetEnumText(linkText))));
                Link.Click();
                IsSuccessful = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Encountered unexpected exception: " + e.Message);
            }
            Logger.log.Info("End.");

            return IsSuccessful;
        }
    }
}
