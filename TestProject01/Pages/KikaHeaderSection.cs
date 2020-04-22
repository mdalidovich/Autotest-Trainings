using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject01.Pages
{
    public class KikaHeaderSection : BasePage
    {
        protected KikaHeaderSection(IWebDriver driver) : base(driver)
        {
        }

        IWebElement searchElement => driver.FindElement(By.Id("quick_search_show"));
        IWebElement iconCountElement => driver.FindElement(By.CssSelector("#cart-info .cnt"));
        IWebElement loginForm => driver.FindElement(By.CssSelector(".need2login"));

        public void ClickOnSearch()
        {
            searchElement.Click();
        }

        public void AssertCountCartItems(int count)
        {
            Assert.AreEqual(count.ToString(), iconCountElement.Text);
          
        }

        public void AssertCountCartItems(string count)
        {
            Assert.AreEqual(count, iconCountElement.Text);
        }

        public LoginPage RequestLoginForm()
        {
            loginForm.Click();
            return new LoginPage(driver);
        }
    }
}
