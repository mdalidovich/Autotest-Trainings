using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject01.Utilities;

namespace TestProject01.Pages
{

    public class KikaHomepage : BasePage
    {
        
        public KikaHomepage(IWebDriver driver) : base(driver) { }
                        
        IWebElement buttonCatsCategory => driver.FindElement(By.CssSelector(".title [href*='katalogas/katems']"));

        public KikaHeaderSection Header => new KikaHeaderSection(driver);

        public KikaHomepage GoTo()
        {
            driver.Url = "https://www.kika.lt/";
            return this;
        }

        public KikaHomepage Login(User user)
        {
            Header.RequestLoginForm().Login(user.Username, user.Password);
            return this;
        }

        public LoginPage RequestLoginForm()
        {
            Header.RequestLoginForm();
            return new LoginPage(driver);
        }


        public void ClickButtonCats()
        {
            buttonCatsCategory.Click();
        }

        
    }
}
