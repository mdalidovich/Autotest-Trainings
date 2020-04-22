using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject01.Pages
{
    public class SearchPage : BasePage
    {
        protected SearchPage(IWebDriver driver) : base(driver)
        {
        }

        IWebElement searchInputElement => driver.FindElement(By.CssSelector("#quick_search.active [name='search']"));

        public void Search(string textCanin)
        {
            searchInputElement.SendKeys(textCanin);
        }
    }
}
