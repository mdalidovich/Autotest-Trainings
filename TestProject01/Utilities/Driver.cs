using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject01.Utilities
{
    public class Driver
    {
        public static IWebDriver Init()
        {
            var options = new ChromeOptions();
            options.AddArguments("incognito", "start-maximized");
            var driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            return driver;
        }
    }
}
