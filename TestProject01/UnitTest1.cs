using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TestProject01.Pages;

namespace TestProject01
{
    public class Tests
    {

        private ChromeDriver driver;
        private KikaHomepage kikaHomepage;
        private PopUpModal popUpModal;
        private CartPage cartPage;
      

        [SetUp]
        public void Driver()
        {
            var options = new ChromeOptions();
            options.AddArguments("incognito", "start-maximized");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            //driver.Url = "https://www.kika.lt/";

            kikaHomepage = new KikaHomepage(driver);
            kikaHomepage.GoTo();
            popUpModal = new PopUpModal(driver);
            cartPage = new CartPage(driver);
            
        }

        [Test]
        public void LoginTest()
        {
            popUpModal.ClickPopUpModal();
           

            kikaHomepage
                .RequestLoginForm()            
                .EnterEmail("mail.for.emails@gmail.com")
                .EnterPassword("password123")
                .ClickLogin()
                .AssertMenuExists();
        }

        [Test]
        public void TestToAddItem()
        {         
            popUpModal.ClickPopUpModal();

            kikaHomepage.ClickButtonCats();
                                 
            cartPage
                .ClickOnItem()
                .ClickAddToCartButton();

            kikaHomepage
                .ClickOnCart()
                .AssertCountCartItems(1);
            
        }

        [TearDown]
        public void ClearUp()
        {
            driver.Quit();
        }

   
    }
}