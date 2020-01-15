using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using log4net;
using log4net.Config;
using System.Linq;

namespace herokuapp.Pages
{
    public static class DropDownList
    {
        public static void SelectOption(IWebDriver driver, string optionToSelect)
        {
            try
            {
                IWebElement DropDownList = driver.FindElement(By.Id("dropdown"));
                var SelectElement = new SelectElement(DropDownList);
                SelectElement.SelectByText(optionToSelect);
            }
            catch (NoSuchElementException)
            {
                throw new Exception("The desired option: '" + optionToSelect + "' does not exist.");
            }
        }

        public static bool VerifyOption(IWebDriver driver, string ExpectedOption)
        {
            bool IsSuccessful = false;
            try
            {
                IWebElement DropDownList = driver.FindElement(By.Id("dropdown"));
                var SelectElement = new SelectElement(DropDownList);
                var ActualOption = SelectElement.SelectedOption.Text;
                if (ActualOption.Equals(ExpectedOption))
                {
                    Console.WriteLine("The option [" + ExpectedOption + "] was selected as expected.");
                    IsSuccessful = true;
                }
                else Console.WriteLine("ERROR: Expected option [" + ExpectedOption + "] to be selected but found " + ActualOption + " was selected.");
            }
            catch (Exception e)
            {
                throw new Exception("Encountered unexpected exception: " + e.Message);
            }
            return IsSuccessful;
        }

        public static List<string> GetAllOptions(IWebDriver driver)
        {
            List<string> Options = new List<string>();
            try
            {
                IWebElement DropDownList = driver.FindElement(By.Id("dropdown"));
                ReadOnlyCollection<IWebElement> AvailableOptions = DropDownList.FindElements(By.TagName("option"));

                foreach (IWebElement option in AvailableOptions)
                {
                    Console.WriteLine("Current Option: " + option.Text);
                    Options.Add(option.Text);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Encountered unexpected exception: " + e.Message);
            }
            return Options;
        }
    }
}
