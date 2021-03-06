﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TestProject01.Pages;
using TestProject01.Tests;

namespace TestProject01
{
    public class Kika : BaseTest

    {
        
        [Test]
        public void LoginTest()
        {
            popUpModal.ClickPopUpModal();


            kikaHomepage.Header
                .RequestLoginForm()
                .EnterEmail("mail.for.emails@gmail.com")
                .EnterPassword("password123")
                .ClickLogin()
                .Header.AssertMenuExists();
        }

        [Test]
        public void TestToAddItem()
        {         
            popUpModal.ClickPopUpModal();

            kikaHomepage.ClickButtonCats();
                                 
            cartPage
                .ClickOnItem()
                .ClickAddToCartButton();

            kikaHomepage.Header
                .ClickOnCart();

            kikaHomepage.Header.AssertCountCartItems(1);
            
        }

        

   
    }
}