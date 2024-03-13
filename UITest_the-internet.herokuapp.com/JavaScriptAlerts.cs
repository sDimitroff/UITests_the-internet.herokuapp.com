using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class JavaScriptAlerts : BaseTestClass
    
    {
        [Test]
        public void JavaScriptAlertsTest()
        {
            driver.FindElement(By.LinkText("JavaScript Alerts")).Click();
            driver.FindElement(By.CssSelector("#content > div > ul > li:nth-child(1) > button")).Click();

            IAlert a = driver.SwitchTo().Alert();
            a.Accept();
            Task.Delay(1000).Wait();

            driver.FindElement(By.CssSelector("#content > div > ul > li:nth-child(2) > button")).Click();
            IAlert b = driver.SwitchTo().Alert();
            b.Dismiss();
            Task.Delay(1000).Wait();

            driver.FindElement(By.CssSelector("#content > div > ul > li:nth-child(3) > button")).Click();

            IAlert c = driver.SwitchTo().Alert();
            string someText = "OpenQA Automation";
            c.SendKeys(someText);
            c.Accept();


            var textField = driver.FindElement(By.Id("result"));
            Assert.That(textField.Text, Is.EqualTo("You entered: " + someText));
            Task.Delay(3000).Wait();
        }




    }
}
