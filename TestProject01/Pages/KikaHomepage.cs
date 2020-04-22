using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject01.Pages
{

    public class KikaHomepage : BasePage
    {
        
        public KikaHomepage(IWebDriver driver) : base(driver) { }
        
        IWebElement menuElement => driver.FindElement(By.CssSelector("#profile_menu.dropdown"));

        IWebElement loginForm => driver.FindElement(By.CssSelector(".need2login"));
        IWebElement buttonCatsCategory => driver.FindElement(By.CssSelector(".title [href*='katalogas/katems']"));

        IWebElement cartElement => driver.FindElement(By.Id("cart_info"));             
        IWebElement iconCountElement => driver.FindElement(By.CssSelector("#cart-info .cnt"));

        public KikaHomepage GoTo()
        {
            driver.Url = "https://www.kika.lt/";
        }
    
        public KikaHomepage AssertMenuExists()
        {
            Assert.IsNotNull(menuElement, "User is not logged in");
            return this;
        }

        public LoginPage RequestLoginForm()
        {
            loginForm.Click();
            return new LoginPage(driver);
        }

        public void ClickButtonCats()
        {
            buttonCatsCategory.Click();
        }

        public KikaHomepage ClickOnCart()
        {
            cartElement.Click();
            return this;
        }

        public KikaHomepage AssertCountCartItems(int count)
        {
            Assert.AreEqual(count.ToString(), iconCountElement.Text);
            return this;
        }


    }
}
