using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.IE;
using static herokuapp.Enums;

namespace herokuapp.UserActions
{
    public class WebBrowser
    {
        public IWebDriver LaunchBrowser(BrowerTypes browser)
        {
            IWebDriver driver = null;
            try
            {
                switch (browser)
                {
                    case BrowerTypes.Chrome:
                        {
                            // TODO Add specific options per each driver type as needed 
                            ChromeOptions options = new ChromeOptions();

                            driver = new ChromeDriver();
                            break;
                        }
                    case BrowerTypes.IE:
                        {
                            // TODO Add specific options per each driver type as needed 
                            InternetExplorerOptions options = new InternetExplorerOptions();

                            driver = new InternetExplorerDriver();
                            break;
                        }
                    default:
                        {
                            throw new Exception("Error: Unsupported browser type.");
                        }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Encountered unexpected exception: " + e.Message);
            }
            return driver;
        }

        public void MaximizeBrowser(IWebDriver driver)
        {
            try
            {
                driver.Manage().Window.Maximize();
            }
            catch (Exception e)
            {
                throw new Exception("Encountered unexpected exception: " + e.Message);
            }
        }
    }
}
