using FaceBook.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Linkedin.Pages
{
    public class LoginPage 
    { BaseInvoke baseInvoke = new BaseInvoke();
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
     

          [FindsBy(How = How.ClassName, Using = "nav__button-secondary")]
        [CacheLookup]
        public static IWebElement SignIn { get; set; }

        [FindsBy(How = How.Id, Using = "username")]
        [CacheLookup]
        public static  IWebElement Email { get; set; }


        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        public static IWebElement Password { get; set; }


        [FindsBy(How = How.ClassName, Using = "btn__primary--large from__button--floating")]
        public static IWebElement LoginBu;
        public void Login()
        {

        }
    }

  
}
