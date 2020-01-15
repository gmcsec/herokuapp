using herokuapp.Utilities;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static herokuapp.Enums;

namespace herokuapp.TestCases
{
    public static class DropDownList
    {

        public static void TestDropDownList(IWebDriver driver)
        {            
            Rootobject TestData = GetTestData();
            for (int x = 0; x < TestData.TestCases.Length; x++)
            {
                Console.WriteLine("Starting Test case:" + TestData.TestCases[x].TestCaseName);
                driver.Navigate().GoToUrl(Configuration.HomePageURL);
                HomePage.ClickLinkText(driver, HomePageLinks.Dropdown);
                Pages.DropDownList.SelectOption(driver, GetTestData().TestCases[x].DropDownOption);
            }
            

        }
        public static Rootobject GetTestData()
        {
            Rootobject root = null;

            // TODO - Need a way to cleanly get the corresponding json file in the TestCases folder
            string FilePath = "../../../TestCases/DropDownList.json";
            string json = String.Empty;

            using (StreamReader reader = new StreamReader(FilePath))
            {
                json = reader.ReadToEnd();
            }

            root = JsonConvert.DeserializeObject<Rootobject>(json);
            Logger.log.Info("End");

            return root;
        }
        
        public class Rootobject
        {
            public Testcase[] TestCases { get; set; }
        }

        public class Testcase
        {
            public string TestCaseName { get; set; }
            public string DropDownOption { get; set; }
        }

    }
}
