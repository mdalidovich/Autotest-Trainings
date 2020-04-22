using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject01.Pages
{
    public class PopUpModal : BasePage
    {
        public PopUpModal(IWebDriver driver) : base(driver) { }
       
        IWebElement popupElement => driver.FindElement(By.CssSelector("#editable_popup[style*='display: block;'] .close"));

        public void ClickPopUpModal()
        {
            popupElement.Click();
        }
    }
}
