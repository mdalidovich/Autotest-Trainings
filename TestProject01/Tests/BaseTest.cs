using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject01.Pages;
using TestProject01.Utilities;

namespace TestProject01.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected KikaHomepage kikaHomepage;
        protected PopUpModal popUpModal;
        protected CartPage cartPage;

        [SetUp]
        public void BeforeTest()
        {
            driver = Driver.Init();
            IntPages();
            kikaHomepage.GoTo();
            popUpModal = new PopUpModal(driver);
            cartPage = new CartPage(driver);

        }

        private void IntPages()
        {
            kikaHomepage = new KikaHomepage(driver);

        }

        [TearDown]
        public void ClearUp()
        {
            driver.Quit();
        }
    }
}
