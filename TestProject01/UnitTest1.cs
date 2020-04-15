using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Collections.Generic;

namespace TestProject01
{
    public class Tests
    {

        private ChromeDriver driver;
        private IWebElement popupElement => driver.FindElement(By.CssSelector("#editable_popup[style*='display: block;'] .close"));
        private IWebElement loginForm => driver.FindElement(By.CssSelector(".need2login"));

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
        public void Login()
        {
            //remove pop-up
            //driver.FindElement(By.CssSelector("#editable_popup[style*='display: block;'] .close")).Click();
            popupElement.Click();

            //request the log in window
            Thread.Sleep(5000);
            //driver.FindElement(By.CssSelector(".need2login")).Click();

            loginForm.Click();

            //enter login credentials
            //driver.FindElement(By.CssSelector("#login_form [name='email']")).SendKeys("mail.for.emails@gmail.com");
            IWebElement loginField = driver.FindElement(By.CssSelector("#login_form [name='email']"));
            loginField.Click();

            Thread.Sleep(5000);

            //driver.FindElement(By.CssSelector("#login_form [name='password']")).SendKeys("password123");
            IWebElement fieldPassword = driver.FindElement(By.CssSelector("#login_form [name='password']"));
            fieldPassword.Click();

            //driver.FindElement(By.CssSelector("#login_form .btn-primary")).Click();
            IWebElement buttonLogin = driver.FindElement(By.CssSelector("#login_form .btn-primary"));
            buttonLogin.Click();
        }

        [Test]
        public void Test1()
        {
            Thread.Sleep(5000);

            //remove pop-up again
            driver.FindElement(By.CssSelector("#editable_popup[style*='display: block;'] .close")).Click();

            //press on the cats' category
            driver.FindElement(By.CssSelector(".title [href*='katalogas/katems']")).Click();

            //press on the first item on the page
            driver.FindElement(By.CssSelector("#products_column > div.product_listing > div > div:nth-child(1) > a > span.img-wrapper > span > img")).Click();
            
            //add item to the cart
            driver.FindElement(By.CssSelector("#add2cart_button")).Click();
                                    
        }

        [TearDown]
        public void ClearUp()
        {
            driver.Quit();
        }

       
    }
}