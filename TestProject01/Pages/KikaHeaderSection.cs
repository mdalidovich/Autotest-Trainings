using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject01.Pages
{
    public class KikaHeaderSection : BasePage
    {
        public KikaHeaderSection(IWebDriver driver) : base(driver)
        {
        }
        IWebElement menuElement => driver.FindElement(By.CssSelector("#profile_menu.dropdown"));
        IWebElement searchElement => driver.FindElement(By.Id("quick_search_show"));
        
        IWebElement loginForm => driver.FindElement(By.CssSelector(".need2login"));
        IWebElement cartElement => driver.FindElement(By.Id("cart_info"));
        IWebElement iconCountElement => driver.FindElement(By.CssSelector("#cart-info .cnt"));


        public SearchPage ClickOnSearch()
        {
            searchElement.Click();
            return new SearchPage(driver);
        }
        public LoginPage RequestLoginForm()
        {
            loginForm.Click();
            return new LoginPage(driver);
        }
        public void ClickOnCart()
        {
            cartElement.Click();

        }

        public void AssertCountCartItems(int count)
        {
            Assert.AreEqual(count.ToString(), iconCountElement.Text);
          
        }

        public void AssertCountCartItems(string count)
        {
            Assert.AreEqual(count, iconCountElement.Text);
        }
            
        public void AssertMenuExists()
        {
            Assert.IsNotNull(menuElement, "User is not logged in");
            
        }
        
    }
}
