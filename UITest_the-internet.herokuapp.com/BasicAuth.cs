using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

namespace UITest_the_internet.herokuapp.com
{
    internal class BasicAuth : BaseTestClass
    {

       
        [Test]
        public void AuthWithValidUser()
        {


            var basicAuth = driver.FindElement(By.LinkText("Basic Auth"));
            basicAuth.Click();


            IAlert a = driver.SwitchTo().Alert();
            a.SendKeys("admin");
            //Actions actions = new Actions(driver);
            Task.Delay(3000);

        }
    }
}
