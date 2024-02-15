using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class EntryAd : BaseTestClass
    
    {
        [Test]
        public void EntryAdTest()
        {
            var EntryAdLink = driver.FindElement(By.LinkText("Entry Ad"));
            EntryAdLink.Click();

            var modalWindow = driver.FindElement(By.Id("modal"));
            Task.Delay(2000).Wait();

            Assert.True(modalWindow.Displayed);

            var closeButton = driver.FindElement(By.CssSelector("#modal > div.modal > div.modal-footer > p"));
            closeButton.Click();



        }




    }
}
