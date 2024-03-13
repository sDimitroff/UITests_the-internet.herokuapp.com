using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace UITest_the_internet.herokuapp.com
{
    public class Class1 : BaseTestClass
    
    {
        [Test]
        public void Hovers()
        {
            driver.FindElement(By.LinkText("Hovers")).Click();
            var firstImage = driver.FindElement(By.CssSelector("#content > div > div:nth-child(3) > img"));
            var secondImage = driver.FindElement(By.CssSelector("#content > div > div:nth-child(4) > img"));
            var thirdImage = driver.FindElement(By.CssSelector("#content > div > div:nth-child(5) > img"));
            var firstImageAdditionalInformation = driver.FindElement(By.CssSelector("#content > div > div:nth-child(3) > div > h5"));
            var secondImageAdditionalInformation = driver.FindElement(By.CssSelector("#content > div > div:nth-child(4) > div > h5"));
            var thirdImageAdditionalInformation = driver.FindElement(By.CssSelector("#content > div > div:nth-child(5) > div > h5"));


            Actions actions = new Actions(driver);

            actions.MoveToElement(firstImage).Build().Perform();

            Assert.True(firstImageAdditionalInformation.Displayed);
            
             
            actions.MoveToElement(secondImage).Perform();
            Assert.True(secondImageAdditionalInformation.Displayed);

            actions.MoveToElement(thirdImage).Perform();
            Assert.True(thirdImageAdditionalInformation.Displayed);

        }




    }
}
