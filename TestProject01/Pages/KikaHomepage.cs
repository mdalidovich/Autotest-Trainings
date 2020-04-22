using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject01.Pages
{

    public class KikaHomepage : BasePage
    {
        
        public KikaHomepage(IWebDriver driver) : base(driver) { }
        
        IWebElement menuElement => driver.FindElement(By.CssSelector("#profile_menu.dropdown"));

        
        IWebElement buttonCatsCategory => driver.FindElement(By.CssSelector(".title [href*='katalogas/katems']"));

        IWebElement cartElement => driver.FindElement(By.Id("cart_info"));             
        

        


        public KikaHomepage GoTo()
        {
            driver.Url = "https://www.kika.lt/";
            return this;
        }

        
    
        public KikaHomepage AssertMenuExists()
        {
            Assert.IsNotNull(menuElement, "User is not logged in");
            return this;
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

        


    }
}
