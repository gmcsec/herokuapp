using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace herokuapp.Pages
{
    public class SecureArea
    {
        public void ClickLogout(IWebDriver driver)
        {
            try
            {
                IWebElement LogoutPageForm = driver.FindElement(By.Id("content"));
                IWebElement LogoutButton = LogoutPageForm.FindElement(By.XPath("div/a"));
                LogoutButton.Click();
            }
            catch (NoSuchElementException)
            {
                throw new Exception("Couldn't find the Logout button element.");
            }
            catch (Exception e)
            {
                throw new Exception("Encountered unexpected exception: " + e.Message);
            }
        }
    }
}
