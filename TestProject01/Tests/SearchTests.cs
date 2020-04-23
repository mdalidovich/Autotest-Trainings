using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject01.Utilities;

namespace TestProject01.Tests
{
    public class SearchTests : BaseTest
    {
        [SetUp]
        public void Before()
        {
            kikaHomepage.Login(User.DefualtKikaUser);

        }

        [Test]

        public void SearchTestKika()
        {
            kikaHomepage.Header.ClickOnSearch().Search("canin");
            //Assert

        }
    }
}
