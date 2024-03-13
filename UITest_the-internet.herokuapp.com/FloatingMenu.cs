using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class FloatinMenu : BaseTestClass
    
    {
        [Test]
        public void FloatinMenuTest()
        {
            var floatingMenuLink = driver.FindElement(By.LinkText("Floating Menu"));
            floatingMenuLink.Click();
            var contactMenuButton = driver.FindElement(By.LinkText("Contact"));
            Task.Delay(1000).Wait();

            Console.WriteLine(contactMenuButton.Location);



            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0,950)", "");

            var contactMenuButton1 = driver.FindElement(By.LinkText("Contact"));
            Task.Delay(1000).Wait();

            Console.WriteLine(contactMenuButton1.Location);

            jse.ExecuteScript("window.scrollBy(0,950)", "");

            var contactMenuButton2 = driver.FindElement(By.LinkText("Contact"));
            Task.Delay(3000).Wait();

            Console.WriteLine(contactMenuButton2.Location);

            Assert.That(contactMenuButton.Location.Y, Is.Not.EqualTo(contactMenuButton1.Location.Y));
            Assert.That(contactMenuButton1.Location.Y, Is.Not.EqualTo(contactMenuButton2.Location.Y));


            
           // Standard Output is: 
           //{ X = 777,Y = 37}
           //{ X = 777,Y = 949}
           //{ X = 777,Y = 1899}
           //The location of element is different each time, but it says its equal and the test fails. Maybe it's a bug in Selenium web driver


            
            
            Task.Delay(3000).Wait();

        }




    }
}
