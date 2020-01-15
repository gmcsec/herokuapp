using herokuapp.Pages;
using herokuapp.UserActions;
using herokuapp.TestCases;
using herokuapp.Utilities;
using log4net;
using OpenQA.Selenium;
using System;
using static herokuapp.Enums;

namespace herokuapp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver WebDriver = null;

            try
            {
                WebBrowser BrowserSession = new WebBrowser();
                WebDriver = BrowserSession.LaunchBrowser(Configuration.Browser);
                BrowserSession.MaximizeBrowser(WebDriver);

               //TestCases.DropDownList.TestDropDownList();
               // test
                #region Test Case: Click the dropdown link and select the second option
                // Coded the DropDownList as Static for this example - this was how we coded framework at previous job.  The goal was to make it easy for QAers without coding experience to create test cases.
                WebDriver.Navigate().GoToUrl(Configuration.HomePageURL);
                HomePage.ClickLinkText(WebDriver, HomePageLinks.Dropdown);
                Pages.DropDownList.SelectOption(WebDriver, "Option 2");
                Pages.DropDownList.VerifyOption(WebDriver, "Option 2");
                #endregion

                #region Test Case Go the Javascript Alerts page and launch/dismiss the JS Alert
                WebDriver.Navigate().GoToUrl(Configuration.HomePageURL);
                HomePage.ClickLinkText(WebDriver, HomePageLinks.JavaScriptAlerts);
                JavaScriptAlerts Alert = new JavaScriptAlerts();
                Alert.ClickJavascriptButton(WebDriver, JavaScriptAlerts.JSButtons.JSAlert);
                WebDriver.SwitchTo().Alert().Accept();
                #endregion

                #region Test Case: Go to the Form Authentication Page, Login and Logout
                WebDriver.Navigate().GoToUrl(Configuration.HomePageURL);
                HomePage.ClickLinkText(WebDriver, HomePageLinks.FormAuthentication);
                FormAuthentication Login = new FormAuthentication();
                Login.EnterUsername(WebDriver, Configuration.Username);
                Login.EnterPassword(WebDriver, Configuration.Password);
                Login.ClickLogin(WebDriver);
                SecureArea LogoutForm = new SecureArea();
                LogoutForm.ClickLogout(WebDriver);
                #endregion

                #region Test Case: Go to the WYSIWYG Page, clear out existing text and add new text
                WebDriver.Navigate().GoToUrl(Configuration.HomePageURL);
                HomePage.ClickLinkText(WebDriver, HomePageLinks.WYSIWYGEditor);
                WYSIWYG WYSIWYGFrame = new WYSIWYG();
                WYSIWYGFrame.AddText(WebDriver, "Add this text to the WYSIWYG Text field.", true);
                WebDriver.SwitchTo().ParentFrame();
                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine("Encountered unexpected exception: " + e.Message);
            }
            finally
            {
                // Close the browser and driver
                WebDriver.Quit();

                Environment.Exit(1);
            }
        }
    }
}
