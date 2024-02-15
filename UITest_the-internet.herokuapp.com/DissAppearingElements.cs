using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.DevTools.V121.FedCm;

namespace UITest_the_internet.herokuapp.com
{
    public class DissAppearingElements : BaseTestClass


    {

        [Test]
        public void DissAppearingElementsWhenPageIsOpened()
        {
            var dissAppearingElementsLink = driver.FindElement(By.LinkText("Disappearing Elements"));
            dissAppearingElementsLink.Click();


            try
            {
                IWebElement galleryButton = driver.FindElement(By.LinkText("Gallery"));
                galleryButton.Click();
                Console.WriteLine("Element found");
                Assert.That(driver.Url, Is.EqualTo("https://the-internet.herokuapp.com/gallery/"));
            }
            catch (OpenQA.Selenium.NoSuchElementException ex)
            {
               // Console.WriteLine(ex.Message);
                Assert.Fail(ex.Message);
            }


        }
    }
}
