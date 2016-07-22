using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }   

        [SetUp]
        public void OpenSite()
        {
        driver.Navigate().GoToUrl("http://www.myscore.com.ua/");
        }

        [Test]
        public void LoginElement()
        {
            //Login Button
            
            IWebElement el_1 = driver.FindElement(By.Id("signIn"));

            el_1.Click();

            driver.FindElement(By.Id("email"));
            driver.FindElement(By.Id("passwd"));

            // LoginEmptyFields

            IWebElement el_2 = driver.FindElement(By.Id("login"));
            el_2.Click();

            driver.FindElement(By.ClassName("err-msg-wrapper"));

            
        }

        /*[Test]
        public void LoginFailFields()
        {
            
         }*/
        
        [TearDown]
        public void Exit()
        {
            driver.Quit();

        }
            
        
    }
}
