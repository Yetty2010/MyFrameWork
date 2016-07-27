using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Project1.TkMaxWebTest
{
    [TestClass]
  public class TkMaxuserTest
    {
        private IWebDriver _driver;

       // [TestMethod, TestCategory("HomeTest")]
       // public void checkHomePageIsLoaded()
       // {
         //   string pageSource = _driver.PageSource; 
              //  bool ans = _driver.PageSource.ToLower().Contains("findstore".ToLower());
           // Assert.IsTrue(ans);//
       // }

        [TestMethod,TestCategory("UAT")]
        public void SignIn()
        {
            
        }


        [TestInitialize]
        public void Precondition()
        {
            Console.WriteLine("This is pre condition ");

        }

        [TestCleanup]
        public void Postcondtition()
        {
            Console.WriteLine("This run after the precondition");
        }


    }



}
