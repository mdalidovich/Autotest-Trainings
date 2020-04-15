﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TestProject01
{
    public class Tests
    {

        private ChromeDriver driver;
        IWebElement popupElement => driver.FindElement(By.CssSelector("#editable_popup[style*='display: block;'] .close"));
        IWebElement loginForm => driver.FindElement(By.CssSelector(".need2login"));
        IWebElement loginField => driver.FindElement(By.CssSelector("#login_form [name='email']"));
        IWebElement passwordField => driver.FindElement(By.CssSelector("#login_form [name='password']"));
        IWebElement buttonLogin => driver.FindElement(By.CssSelector("#login_form .btn-primary"));
        IWebElement buttonCatsCategory => driver.FindElement(By.CssSelector(".title [href*='katalogas/katems']"));
        IWebElement purchaseItem => driver.FindElement(By.CssSelector("#products_column > div.product_listing > div > div:nth-child(1) > a > span.img-wrapper > span > img"));
        IWebElement buttonAddToCart => driver.FindElement(By.CssSelector("#add2cart_button"));
        IWebElement cart => driver.FindElement(By.Id("cart_info"));
        
        [SetUp]
        public void Driver()
        {
            var options = new ChromeOptions();
            options.AddArguments("incognito", "start-maximized");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.kika.lt/";
        }

        [Test]
        public void LoginTest()
        {
            popupElement.Click();
            Thread.Sleep(5000);
            loginForm.Click();
            loginField.SendKeys("mail.for.emails@gmail.com");
            Thread.Sleep(5000);
            passwordField.SendKeys("password123");                        
            buttonLogin.Click();

            Assert.IsNotNull(driver.FindElementByCssSelector("#profile_menu.dropdown"), "User is not logged in");
        }

        [Test]
        public void TestToAddItem()
        {         
            popupElement.Click();                     
            buttonCatsCategory.Click();                        
            purchaseItem.Click();            
            buttonAddToCart.Click();            
            cart.Click();

            Assert.AreEqual("1", driver.FindElement(By.CssSelector("#cart_info .cnt")).Text);
        }

        [TearDown]
        public void ClearUp()
        {
            driver.Quit();
        }

       
    }
}