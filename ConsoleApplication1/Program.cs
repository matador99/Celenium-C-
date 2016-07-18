using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        public void ExecuteTest()
        {
        IWebElement el_1 = driver.FindElement(By.Id("signIn"));

        el_1.Click();

        IWebElement el_2 = driver.FindElement(By.Id("email"));
        IWebElement el_3 = driver.FindElement(By.Id("passwd"));
        IWebElement el_4 = driver.FindElement(By.Id("login"));

        el_4.Click();
        }

        [TearDown]
        public void Exit()
        {
            driver.Close();

        }
            
        
    }
}
