using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class NotificationMessages : BaseTestClass
    
    {
        [Test]
        public void NotificationMessagesTest ()
        {
            driver.FindElement(By.LinkText("Notification Messages")).Click();
            driver.FindElement(By.LinkText("Click here"));

            var flashMessage = driver.FindElement(By.Id("flash"));
            Assert.That(flashMessage.Text, Is.EqualTo("Action unsuccesful, please try again\r\n×"));



        }






    }
}
