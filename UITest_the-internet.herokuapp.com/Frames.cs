using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace UITest_the_internet.herokuapp.com
{
    public class Frames : BaseTestClass
    
    {
        [Test]
        public void NestedFramesTest()
        {
            var frameLink = driver.FindElement(By.LinkText("Frames"));
            frameLink.Click();

            var nestedFramesLink = driver.FindElement(By.LinkText("Nested Frames"));
            nestedFramesLink.Click();

            driver.SwitchTo().Frame("frame-top");
            driver.SwitchTo().Frame("frame-left");
            var firstFrameBody = driver.FindElement(By.XPath("/html/body"));
            Assert.That(firstFrameBody.Text, Is.EqualTo("LEFT"));
            
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().Frame("frame-middle");

            var middleFrameBody = driver.FindElement(By.Id("content"));
            Assert.That(middleFrameBody.Text, Is.EqualTo("MIDDLE"));


            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().Frame("frame-right");
            var rightFrameBody = driver.FindElement(By.XPath("/html/body"));
            Assert.That(rightFrameBody.Text, Is.EqualTo("RIGHT"));

            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame("frame-bottom");

            var bottomFrameBody = driver.FindElement(By.XPath("/html/body"));
            Assert.That(bottomFrameBody.Text, Is.EqualTo("BOTTOM"));




        }

        public void IFrames()
        {
            var frameLink = driver.FindElement(By.LinkText("Frames"));
            frameLink.Click();

            var iFrameLink = driver.FindElement(By.LinkText("iFrame"));
            iFrameLink.Click();


        }


    }
}
