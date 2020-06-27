using DocumentFormat.OpenXml.Math;
using FaceBook;
using FaceBook.Base;
using Linkedin.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Linkedin.Test_Senarios
{
    public class LinkedinTEST
    {
        public IWebDriver driver;
        public BaseInvoke baseInvoke; //= new BaseInvoke();
        [SetUp]
        public void Initialisation()
        {
            baseInvoke = new BaseInvoke();
            baseInvoke.Start(DataAccess.BaseURL);
        }



        [Test]
        public void LoginTest()
        {
            LoginPage.SignIn.Click();
            Thread.Sleep(500);
            Console.WriteLine(DataAccess.email);
            LoginPage.Email.SendKeys(DataAccess.email);// username
            LoginPage.Password.SendKeys(DataAccess.password);//password
            Thread.Sleep(500);
            LoginPage.LoginBu.Click();
        }
    }
}
