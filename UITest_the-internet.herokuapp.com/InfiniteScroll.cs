using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace UITest_the_internet.herokuapp.com
{
    public class CInfiniteScroll : BaseTestClass

    {
        [Test]
        public void InfiniteScroll()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Infinite Scroll")).Click();
            Task.Delay(1000).Wait();


            // Actions action = new Actions(driver);
            //
            //action.SendKeys(Keys.PageDown).Build().Perform();
            //Task.Delay(1000).Wait();
            //action.SendKeys(Keys.PageDown).Build().Perform();
            //Task.Delay(1000).Wait();
            //action.SendKeys(Keys.PageDown).Build().Perform();
            //Task.Delay(1000).Wait();
            //action.SendKeys(Keys.PageDown).Build().Perform();
            //Task.Delay(1000).Wait();
            //action.SendKeys(Keys.PageDown).Build().Perform();



            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollTo(0,543)");
            Task.Delay(1000).Wait();
            js.ExecuteScript("window.scrollTo(0,1498)");
            Task.Delay(1000).Wait();
            js.ExecuteScript("window.scrollTo(0,1990)");
            Task.Delay(1000).Wait();
            js.ExecuteScript("window.scrollTo(0,2460)");
            Task.Delay(1000).Wait();

            
            var addedParagraphes = driver.FindElements(By.ClassName("jscroll-added"));
            Task.Delay(1000).Wait();



            Assert.True(addedParagraphes[4].Displayed);

            Task.Delay(3000).Wait();







        }
    }
}
