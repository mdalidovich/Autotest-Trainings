using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject01.Pages
{
    public class PopUpModal
    {
        private ChromeDriver driver;

        public PopUpModal(ChromeDriver driver)
        {
            this.driver = driver;
        }

        IWebElement popupElement => driver.FindElement(By.CssSelector("#editable_popup[style*='display: block;'] .close"));

        public void ClickPopUpModal()
        {
            popupElement.Click();
        }
    }
}
