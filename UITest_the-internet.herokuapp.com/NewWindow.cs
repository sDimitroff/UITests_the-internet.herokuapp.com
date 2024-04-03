using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class NewWindow : BaseTestClass
    
    {
        [Test]
        public void NewWindowTest ()
        {

            driver.FindElement(By.LinkText("Multiple Windows")).Click();
            driver.FindElement(By.LinkText("Click Here")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Assert.That(driver.Title, Is.EqualTo("New Window"));



        }




    }
}
