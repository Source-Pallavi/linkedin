using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaceBook.Base
{
    public class BaseInvoke
    {
        IWebDriver driver;
        public void Start(string URL)
        {
            ChromeOptions opt = new ChromeOptions();
            opt.AddArguments("--disable-notofications");
            driver = new ChromeDriver(opt);
            driver.Url = URL;

        }
    }
}
