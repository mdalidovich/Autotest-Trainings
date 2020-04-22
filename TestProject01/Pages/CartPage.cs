using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject01.Pages
{
    public class CartPage : BasePage
    {
        public CartPage (IWebDriver driver) : base(driver) { }
        

        IWebElement purchaseItem => driver.FindElement(By.CssSelector("#products_column > div.product_listing > div > div:nth-child(1) > a > span.img-wrapper > span > img"));
        IWebElement buttonAddToCart => driver.FindElement(By.CssSelector("#add2cart_button"));

        public CartPage ClickOnItem()
        {
            purchaseItem.Click();
            return this;
        }

        public CartPage ClickAddToCartButton()
        {
            buttonAddToCart.Click();
            return this;
        }
    }
}
