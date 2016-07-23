using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SeleniumActions
    {
        //Enter Text
        public static void EnterText(IWebDriver driver, string element, string value, string type)
        {
            if (type == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (type == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
            if (type == "ClassName")
                driver.FindElement(By.ClassName(element)).SendKeys(value);
        }

        //Click object

        public static void Click(IWebDriver driver, string element, string type)
        {
            if (type == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (type == "Name")
                driver.FindElement(By.Name(element)).Click();
            if (type == "ClassName")
                driver.FindElement(By.ClassName(element)).Click();
           
        }


    }
}
