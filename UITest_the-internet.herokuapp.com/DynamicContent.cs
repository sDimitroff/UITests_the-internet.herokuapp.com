using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class DynamicContentTest : BaseTestClass

    {
        [Test]
        public void DynamicContent()
        {
            var dynamicContentLink = driver.FindElement(By.LinkText("Dynamic Content"));
            dynamicContentLink.Click();


            var firstFieldText = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[1]/div[2]")).Text;
            var secondFieldText = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[2]/div[2]")).Text;
            var thirdFieldText = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[3]/div[2]")).Text;

            var firstImage = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[3]/div[1]/img"));
            var secondImage = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[2]/div[1]/img"));
            var thirdImage = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[3]/div[1]/img"));



            driver.Navigate().Refresh();


            var firstFieldTextAfterRefresh = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[1]/div[2]")).Text;
            var secondFieldTextAfterRefresh = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[2]/div[2]")).Text;
            var thirdFieldTextAfterRefresh = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[3]/div[2]")).Text;

            var firstImageAfterRefresh = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[3]/div[1]/img"));
            var secondImageAfterRefresh = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[2]/div[1]/img"));
            var thirdImageAfterRefresh = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[3]/div[1]/img"));

            //assert text is changed
            Assert.AreNotSame(firstFieldText, firstFieldTextAfterRefresh);
            Assert.AreNotSame(secondFieldText, secondFieldTextAfterRefresh);
            Assert.AreNotSame(thirdFieldText, thirdFieldTextAfterRefresh);


            //assert image is changed
            Assert.AreNotSame(firstImage, firstImageAfterRefresh);
            Assert.AreNotSame(secondImage, secondImageAfterRefresh);
            Assert.AreNotSame(thirdImage, thirdImageAfterRefresh);


        }




    }
}
