using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Project1.TkMaxWebTest
{
    [TestClass]
  public class LoginTest
    {
        private IWebDriver _driver ;
        [TestInitialize]
        public void Precondition()
        {
         _driver = new ChromeDriver();
            _driver .Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.tkmaxx.com/");
            IList<Cookie> cookies = _driver.Manage().Cookies.AllCookies;
            foreach (var cookie in cookies)
            {
                Console.WriteLine(cookie);  
            }
            _driver.Manage().Cookies.DeleteAllCookies();
        }

        [TestCleanup]
        public void Postcondtition()
        {
         //  _driver.Quit();
        }




        [TestMethod,TestCategory("SmokeTest")]
        public void TestForLogin()
        {
            string pageSource = _driver.PageSource;
            Console.WriteLine(pageSource);
            bool ans = _driver.PageSource.ToLower().Contains("findstore".ToLower());
            Assert.IsTrue(ans);
        }



    }
}
