using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace herokuapp.Pages
{
    public class FormAuthentication
    {
        public IWebElement LoginPageForm = null;
        
        public void EnterUsername(IWebDriver driver, string username)
        {
            try
            {
                IWebElement UserName = driver.FindElement(By.Id("username"));
                UserName.SendKeys(username);
            }
            catch (NoSuchElementException)
            {
                throw new Exception("Couldn't find the Username Input element.");
            }
        }

        public void EnterPassword(IWebDriver driver, string password)
        {
            try
            {
                IWebElement UserName = driver.FindElement(By.Id("password"));
                UserName.SendKeys(password);
            }
            catch (NoSuchElementException)
            {
                throw new Exception("Couldn't find the password Input element.");
            }
        }

        public void ClickLogin(IWebDriver driver)
        {
            try
            {
                LoginPageForm = driver.FindElement(By.Id("login"));
                IWebElement Submit = LoginPageForm.FindElement(By.XPath("button"));
                Submit.Click();
            }
            catch (NoSuchElementException)
            {
                throw new Exception("Couldn't find the submit element.");
            }
            catch (Exception e)
            {
                throw new Exception("Encountered unexpected exception: " + e.Message);
            }
        }
    }
}
