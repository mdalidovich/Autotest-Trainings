using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject01.Pages
{
    public class LoginPage
    {
        private ChromeDriver driver;

        public LoginPage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        private const string LoginId = "login_form";
        
        IWebElement loginField => driver.FindElement(By.CssSelector($"#{LoginId} [name='email']"));
        IWebElement passwordField => driver.FindElement(By.CssSelector($"#{LoginId} [name='password']"));
        IWebElement buttonLogin => driver.FindElement(By.CssSelector($"#{LoginId} .btn-primary"));

        public KikaHomepage Login(string email, string password)
        {
            EnterEmail(email);
            EnterPassword(password);
            return ClickLogin();

        }
       
        public LoginPage EnterEmail(string email)
        {
            loginField.SendKeys(email);
            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            passwordField.SendKeys(password);
            return this;
        }

        public KikaHomepage ClickLogin()
        {
            buttonLogin.Click();
            return new KikaHomepage(driver);
        }
    }
}
