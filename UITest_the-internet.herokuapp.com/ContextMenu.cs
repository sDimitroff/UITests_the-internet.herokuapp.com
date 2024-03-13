using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace UITest_the_internet.herokuapp.com
{
    internal class ContextMenu : BaseTestClass
    {

        

        [Test]
        public void ContextMenuClick()
        {


            var checkBoxLink = driver.FindElement(By.LinkText("Context Menu"));
            checkBoxLink.Click();

            var hotSpot = driver.FindElement(By.Id("hot-spot"));
            Actions actions = new Actions(driver);
            actions.ContextClick(hotSpot).Perform();


            //Assert JS alert is displayed and contains the string "You selected a context menu"
            string text = driver.SwitchTo().Alert().Text;
            Assert.That(text.Contains("You selected a context menu"));
            

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

            Task.Delay(2000);
          
        

        }
    }
}
