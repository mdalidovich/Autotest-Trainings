using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject01.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
