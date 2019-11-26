using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using static herokuapp.Enums;

namespace herokuapp.Pages
{
    public class WYSIWYG
    {
        public void AddText(IWebDriver driver, string Text, bool RemoveExistingText)
        {
            try
            {
                IWebElement WYSIWYGFrame = GetWYSIWYGFrame(driver);
                driver.SwitchTo().Frame(WYSIWYGFrame);
                IWebElement WYSIWYGTextField = GetWYSIWYGTextField(driver);
                if (RemoveExistingText) WYSIWYGTextField.Clear();
                WYSIWYGTextField.SendKeys(Text);
            }
            catch (Exception e)
            {
                throw new Exception("Encountered unexpected exception: " + e.Message);
            }
        }

        private IWebElement GetWYSIWYGFrame(IWebDriver driver)
        {
            IWebElement WYSIWYGFrame = null;
            try
            {
                WYSIWYGFrame = driver.FindElement(By.Id("mce_0_ifr"));
            }
            catch (NoSuchElementException)
            {
                throw new Exception("Couldn't find the WYSIWYG frame element.");
            }
            return WYSIWYGFrame;
        }


        private IWebElement GetWYSIWYGTextField(IWebDriver driver)
        {
            IWebElement WYSIWYGEditField = null;
            try
            {
                WYSIWYGEditField = driver.FindElement(By.Id("tinymce"));
            }
            catch (NoSuchElementException)
            {
                throw new Exception("Couldn't find the WYSIWYG text element.");
            }
            return WYSIWYGEditField;
        }
    }
}
