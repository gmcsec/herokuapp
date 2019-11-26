using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace herokuapp.Pages
{
    public class JavaScriptAlerts
    {
        public void ClickJavascriptButton(IWebDriver driver, JSButtons jsButton)
        {
            ReadOnlyCollection<IWebElement> Buttons = driver.FindElements(By.TagName("button"));
            foreach (IWebElement button in Buttons)
            {
                if (button.Text.Equals(Enums.GetEnumText(jsButton)))
                {
                    button.Click();
                    break;
                }
            }
        }

        public enum JSButtons
        {
            [Description("Click for JS Alert")]
            JSAlert,
            [Description("Click for JS Confirm")]
            JSConfirm,
            [Description("Click for JS Prompt")]
            JSPrompt
        }
    }
}
