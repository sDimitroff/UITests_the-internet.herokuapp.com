using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class ShiftingContent : BaseTestClass

    {
        [Test]
        public void ShiftingImageTest()
        {
            driver.FindElement(By.LinkText("Shifting Content")).Click();

            driver.FindElement(By.LinkText("Example 2: An image")).Click();

            var shiftingImageLocation = driver.FindElement(By.ClassName("shift")).Location;
            Console.WriteLine(shiftingImageLocation);

            driver.Navigate().Refresh();
            Task.Delay(3000).Wait();

            var shiftingImageLocationAfterRefresh = driver.FindElement(By.ClassName("shift")).Location;
            Console.WriteLine(shiftingImageLocationAfterRefresh);

            Task.Delay(1000).Wait();

            Assert.That(shiftingImageLocation, Is.Not.EqualTo(shiftingImageLocationAfterRefresh));





        }


        [Test]
        public void ShiftingMenuElementTest()
        {

            driver.FindElement(By.LinkText("Shifting Content")).Click();
            driver.FindElement(By.LinkText("Example 1: Menu Element")).Click();

            Task.Delay(1000).Wait();

            var shiftingElementBeforeRefresh = driver.FindElement(By.LinkText("Gallery")).Location;
            Console.WriteLine(shiftingElementBeforeRefresh);
            driver.Navigate().Refresh();

            var shiftingElementAfterRefresh = driver.FindElement(By.LinkText("Gallery")).Location;
            Console.WriteLine(shiftingElementAfterRefresh);

            Assert.That(shiftingElementBeforeRefresh, Is.Not.EqualTo(shiftingElementAfterRefresh));

        }


        [Test]
        public void ShiftingListCotentTest()
        {
            driver.FindElement(By.LinkText("Shifting Content")).Click();
            driver.FindElement(By.LinkText("Example 3: List")).Click();

            var shiftingContentListText = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div/div")).Text;


            driver.Navigate().Refresh();

            var shiftingContentListTextAfterRefresh = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div/div")).Text;

            Assert.That(shiftingContentListText, Is.Not.EqualTo(shiftingContentListTextAfterRefresh));

        }


    }
}
