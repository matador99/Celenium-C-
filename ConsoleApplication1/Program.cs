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

            SeleniumActions.Click(driver, "signIn", "Id");

            driver.FindElement(By.Id("email"));
            driver.FindElement(By.Id("passwd"));

            // LoginEmptyFields

            SeleniumActions.Click(driver, "login", "Id");

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
