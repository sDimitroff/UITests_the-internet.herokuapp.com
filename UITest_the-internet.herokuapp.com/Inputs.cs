using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class Inputs : BaseTestClass
    
    {
        [Test]
        public void InputsTest()
        
        {
            driver.FindElement(By.LinkText("Inputs")).Click();
            var inputField = driver.FindElement(By.CssSelector("input"));
            inputField.SendKeys("1");
            Task.Delay(2000).Wait();
            inputField.Clear();
            Assert.That(inputField.Text, Is.EqualTo("1"));

            inputField.SendKeys("2");
            Task.Delay(2000).Wait();
            inputField.Clear();
            Assert.That(inputField.Text, Is.EqualTo("2"));

        }




    }
}
