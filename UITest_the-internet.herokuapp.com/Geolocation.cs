using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class Geolocation : BaseTestClass
    
    {
        [Test]
        public void GeolocationTest()
        {
            driver.FindElement(By.LinkText("Geolocation")).Click();
            driver.FindElement(By.CssSelector("#content > div > button")).Click();
            
            Task.Delay(3000).Wait();
            
            driver.FindElement(By.LinkText("See it on Google")).Click();
            
            Task.Delay(3000).Wait();
            driver.FindElement(By.XPath("/html/body/c-wiz/div/div/div/div[2]/div[1]/div[3]/div[1]/div[1]/form[2]/div/div/button/span")).Click();
            Console.WriteLine(driver.Title);
            
            
            Assert.That(driver.Url.Contains("https://www.google.com/maps" ));

            
            
            
            
            
  

        }




    }
}
